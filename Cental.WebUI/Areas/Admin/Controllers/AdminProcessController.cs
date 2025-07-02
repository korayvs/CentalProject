using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ProcessDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminProcessController(IProcessService _processService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _processService.TGetAll();
            var dtos = _mapper.Map<List<ResultProcessDto>>(values);
            return View(dtos);
        }

        public IActionResult CreateProcess()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProcess(CreateProcessDto model)
        {
            var value = _mapper.Map<Process>(model);
            _processService.TCreate(value);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateProcess(int id)
        {
            var value = _processService.TGetById(id);
            var dto = _mapper.Map<UpdateProcessDto>(value);
            return View(dto);
        }

        [HttpPost]
        public IActionResult UpdateProcess(UpdateProcessDto model)
        {
            var value = _mapper.Map<Process>(model);
            _processService.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProcess(int id)
        {
            _processService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
