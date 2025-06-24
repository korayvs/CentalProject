using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BrandDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminBrandController(IBrandService _brandService, IMapper _mapper) : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 3)
        {
            var value = _brandService.TGetAll();
            var dto = _mapper.Map<List<ResultBrandDto>>(value);
            var brands = dto.AsQueryable();
            var values = new PagedList<ResultBrandDto>(brands, page, pageSize);
            return View(values);
        }

        public IActionResult DeleteBrand(int id)
        {
            _brandService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult CreateBrand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBrand(CreateBrandDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var dto = _mapper.Map<Brand>(model);
            _brandService.TCreate(dto);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateBrand(int id)
        {
            var value = _brandService.TGetById(id);
            var dto = _mapper.Map<UpdateBrandDto>(value);
            return View(dto);
        }

        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var dto = _mapper.Map<Brand>(model);
            _brandService.TUpdate(dto);
            return RedirectToAction("Index");
        }
    }
}
