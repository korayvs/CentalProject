using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultFeatureComponent(IFeatureService _featureService, IMapper _mapper) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var valuesFirst2 = _featureService.TGetAll().Take(2);
            ViewBag.valuesfirst2 = _mapper.Map<List<ResultFeatureDto>>(valuesFirst2);
            var valuesLast2 = _featureService.TGetAll().TakeLast(2);
            ViewBag.valuelast2 = _mapper.Map<List<ResultFeatureDto>>(valuesLast2);
            return View();
        }
    }
}
