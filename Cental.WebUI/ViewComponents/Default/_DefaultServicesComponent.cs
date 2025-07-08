using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ServiceDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultServicesComponent(IServiceService _serviceService, IMapper _mapper) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetAll();
            var dtos = _mapper.Map<List<ResultServiceDto>>(values);
            return View(dtos);
        }
    }
}
