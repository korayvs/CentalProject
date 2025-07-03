using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.TestimonialDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminTestimonialController(ITestimonialService _testimonialService, IMapper _mapper, IImageService _imageService) : Controller
    {
        public IActionResult Index()
        {
            var values = _testimonialService.TGetAll();
            var dtos = _mapper.Map<List<ResultTestimonialDto>>(values);
            return View(dtos);
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto model)
        {
            var dto = _mapper.Map<Testimonial>(model);
            if (model.ImageFile != null)
            {
                var imageUrl = await _imageService.SaveImageAsync(model.ImageFile);
                dto.ImageUrl = imageUrl;
            }
            _testimonialService.TCreate(dto);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            var dtos = _mapper.Map<UpdateTestimonialDto>(values);
            return View(dtos);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto model)
        {
            var dto = _mapper.Map<Testimonial>(model);
            if (model.ImageFile != null)
            {
                var imageUrl = await _imageService.SaveImageAsync(model.ImageFile);
                dto.ImageUrl = imageUrl;
            }
            _testimonialService.TUpdate(dto);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            _testimonialService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
