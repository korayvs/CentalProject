using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.ReviewDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class ReviewController(IReviewService _reviewService, ICarService _carService, IMapper _mapper, UserManager<AppUser> _userManager) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _reviewService.TGetReviewByUserId(user.Id);
            return View(values);
        }

        private void SelectCarList()
        {
            var cars = _carService.TGetAll();
            var carList = (from car in cars
                           select new SelectListItem
                           {
                               Text = car.Brand.BrandName + " " + car.ModelName + " " + car.Year,
                               Value = car.CarId.ToString()
                           }).ToList();
            ViewBag.carList = carList;
        }

        public async Task<IActionResult> CreateReview()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = user.Id;
            SelectCarList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateReview(CreateReviewDto model)
        {
            var values = _mapper.Map<Review>(model);
            _reviewService.TCreate(values);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteReview(int id)
        {
            _reviewService.TDelete(id);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateReview(int id)
        {
            SelectCarList();
            var value = _reviewService.TGetById(id);
            var dto = _mapper.Map<UpdateReviewDto>(value);
            return View(dto);
        }

        [HttpPost]
        public IActionResult UpdateReview(UpdateReviewDto model)
        {
            var value = _mapper.Map<Review>(model);
            _reviewService.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
