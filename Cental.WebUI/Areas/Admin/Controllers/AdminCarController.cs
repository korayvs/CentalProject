using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Cental.DtoLayer.CarDtos;
using Cental.DtoLayer.Enums;
using Cental.EntityLayer.Entities;
using Cental.WebUI.Extensions;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList.Core;
using System.Drawing.Printing;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminCarController(ICarService _carService, IMapper _mapper, IBrandService _brandService) : Controller
    {
        private void GetValuesinDropDown()
        {
            ViewBag.gasTypes = GetEnumValues.GetEnums<GasTypes>();
            ViewBag.gearTypes = GetEnumValues.GetEnums<GearTypes>();
            ViewBag.transmissions = GetEnumValues.GetEnums<Transmissions>();
            ViewBag.brands = (from x in _brandService.TGetAll()
                              orderby x.BrandName
                              select new SelectListItem
                              {
                                  Text = x.BrandName,
                                  Value = x.BrandId.ToString(),
                              }).ToList();
        }

        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var values = _carService.TGetAll();
            var cardto = _mapper.Map<List<ResultCarDto>>(values);
            var sortedDto = cardto.OrderBy(x => x.Brand.BrandName).AsQueryable();
            var pagedList = new PagedList<ResultCarDto>(sortedDto, page, pageSize);
            return View(pagedList);
        }

        public IActionResult CreateCar()
        {
            GetValuesinDropDown();
            return View();
        }

        [HttpPost]
        public IActionResult CreateCar(CreateCarDto model)
        {
            var newCar = _mapper.Map<Car>(model);
            _carService.TCreate(newCar);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCar(int id)
        {
            GetValuesinDropDown();
            var model = _carService.TGetById(id);
            var cardto = _mapper.Map<UpdateCarDto>(model);
            return View(cardto);
        }

        [HttpPost]
        public IActionResult UpdateCar(UpdateCarDto model)
        {
            var car = _mapper.Map<Car>(model);
            _carService.TUpdate(car);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCar(int id)
        {
            _carService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
