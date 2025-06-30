using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminFeatureController(IFeatureService _featureService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _featureService.TGetAll();
            var featuremap = _mapper.Map<List<ResultFeatureDto>>(values);
            return View(featuremap);
        }

        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto model)
        {
            var value = _mapper.Map<Feature>(model);
            _featureService.TCreate(value);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateFeature(int id)
        {
            var value = _featureService.TGetById(id);
            var dto = _mapper.Map<UpdateFeatureDto>(value);
            return View(dto);
        }

        [HttpPost]
        public IActionResult UpdateFeature(UpdateFeatureDto model)
        {
            var featuredto = _mapper.Map<Feature>(model);
            _featureService.TUpdate(featuredto);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            _featureService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
