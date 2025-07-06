using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BookingDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminBookingController(IBookingService _bookingService, ICarService _carService, IMapper _mapper, UserManager<AppUser> _userManager) : Controller
    {
        public IActionResult Index()
        {
            var values = _bookingService.TGetAll();
            var dtos = _mapper.Map<List<ResultBookingDto>>(values);
            return View(dtos);
        }

        private List<SelectListItem> UserSelectedList()
        {
            var userList = (from user in _userManager.Users
                            select new SelectListItem
                            {
                                Text = user.FirstName + " " + user.LastName,
                                Value = user.Id.ToString()
                            }).ToList();
            return userList;
        }

        private List<SelectListItem> CarSelectedList()
        {
            var carList = (from car in _carService.TGetAll()
                           orderby car.Brand.BrandName
                           select new SelectListItem
                           {
                               Text = car.Brand.BrandName + " " + car.ModelName + " " + car.Year,
                               Value = car.CarId.ToString()
                           }).ToList();
            return carList;
        }

        public IActionResult CreateRezervation()
        {
            ViewBag.carList = CarSelectedList();
            ViewBag.userList = UserSelectedList();
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

        public IActionResult UpdateRezervation(int id)
        {
            var value = _bookingService.TGetById(id);
            var bookingDto = _mapper.Map<UpdateBookingDto>(value);
            ViewBag.carList = CarSelectedList();
            ViewBag.userList = UserSelectedList();
            return View(bookingDto);
        }

        [HttpPost]
        public IActionResult UpdateRezervation(UpdateBookingDto model)
        {
            var value = _mapper.Map<Booking>(model);
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

            _bookingService.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult ApproveRezervation(int id)
        {
            var value = _bookingService.TGetById(id);
            value.IsApproved = true;
            value.Status = "Onaylandı";
            _bookingService.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult DeclineRezervation(int id)
        {
            var value = _bookingService.TGetById(id);
            value.IsApproved = false;
            value.Status = "Reddedildi";
            _bookingService.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult WaitingRezervation(int id)
        {
            var value = _bookingService.TGetById(id);
            value.IsApproved = null;
            value.Status = "Beklemede";
            _bookingService.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
