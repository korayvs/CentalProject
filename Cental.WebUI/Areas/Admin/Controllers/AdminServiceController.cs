using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ServiceDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminServiceController(IServiceService _serviceService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _serviceService.TGetAll();
            var dtos = _mapper.Map<List<ResultServiceDto>>(values);
            return View(dtos);
        }

        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(CreateServiceDto model)
        {
            var service = _mapper.Map<Service>(model);
            _serviceService.TCreate(service);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateService(int id)
        {
            var values = _serviceService.TGetById(id);
            var dto = _mapper.Map<UpdateServiceDto>(values);
            return View(dto);
        }

        [HttpPost]
        public IActionResult UpdateService(UpdateServiceDto model)
        {
            var values = _mapper.Map<Service>(model);
            _serviceService.TUpdate(values);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            _serviceService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
