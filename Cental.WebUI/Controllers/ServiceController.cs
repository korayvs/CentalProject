using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ServiceDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class ServiceController(IServiceService _serviceService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _serviceService.TGetAll();
            var dtos = _mapper.Map<List<ResultServiceDto>>(values);
            return View(dtos);
        }
    }
}
