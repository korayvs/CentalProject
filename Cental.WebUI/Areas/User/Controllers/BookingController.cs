using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BookingDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class BookingController(UserManager<AppUser> _userManager, IBookingService _bookingService, ICarService _carService, IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _bookingService.TUserBookings(user.Id);
            var bookingDtos = _mapper.Map<List<ResultBookingDto>>(values);
            return View(bookingDtos);
        }

        private List<SelectListItem> CarSelectedList()
        {
            var carList = (from car in _carService.TGetAll()
                           select new SelectListItem
                           {
                               Text = car.Brand.BrandName + " " + car.ModelName + " " + car.Year,
                               Value = car.CarId.ToString()
                           }).ToList();
            return carList;
        }

        public async Task<IActionResult> CreateRezervation()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = user.Id;
            ViewBag.carList = CarSelectedList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateRezervation(CreateBookingDto model)
        {
            var values = _mapper.Map<Booking>(model);
            values.Status = "Beklemede";
            values.IsApproved = null;
            _bookingService.TCreate(values);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRezervation(int id)
        {
            _bookingService.TDelete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateRezervation(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = user.Id;
            var value = _bookingService.TGetById(id);
            if (value.IsApproved == true)
            {
                value.Status = "Onaylandı";
            }
            else if (value.IsApproved == false)
            {
                value.Status = "Reddedildi";
            }
            else
            {
                value.Status = "Beklemede";
            }

            var bookingDto = _mapper.Map<UpdateBookingDto>(value);
            ViewBag.carList = CarSelectedList();
            return View(bookingDto);
        }

        [HttpPost]
        public IActionResult UpdateRezervation(UpdateBookingDto model)
        {
            var value = _mapper.Map<Booking>(model);
            _bookingService.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
