using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BookingDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList.Core;

namespace Cental.WebUI.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize(Roles = "Manager")]
    public class BookingController(IBookingService _bookingService, ICarService _carService, IMapper _mapper) : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var values = _bookingService.TGetAll();
            var dtos = _mapper.Map<List<ResultBookingDto>>(values);
            var bookings = dtos.AsQueryable();
            var pagedList = new PagedList<ResultBookingDto>(bookings, page, pageSize);
            return View(pagedList);
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

        public IActionResult CreateRezervation()
        {            
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

        public IActionResult UpdateRezervation(int id)
        {
            var value = _bookingService.TGetById(id);
            var bookingDto = _mapper.Map<UpdateBookingDto>(value);
            ViewBag.carList = CarSelectedList();
            return View(bookingDto);
        }

        [HttpPost]
        public IActionResult UpdateRezervation(UpdateBookingDto model)
        {
            var value = _mapper.Map<Booking>(model);
            if(value.IsApproved == true)
            {
                value.Status = "Onaylandı";
            }
            else if(value.IsApproved == false)
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
