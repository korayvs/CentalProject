using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BrandDtos;
using Cental.DtoLayer.ReviewDtos;
using Cental.EntityLayer.Entities;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList.Core;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminReviewController(IReviewService _reviewService, ICarService _carService, IMapper _mapper, UserManager<AppUser> _userManager) : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            var value = _reviewService.TGetAll();
            var dtos = _mapper.Map<List<ResultReviewDto>>(value);
            var reviews = dtos.AsQueryable();
            var values = new PagedList<ResultReviewDto>(reviews, page, pageSize);
            return View(values);
        }

        private void SelectUserList()
        {
            var users = _userManager.Users.ToList();
            var userList = (from user in users
                            select new SelectListItem
                            {
                                Text = user.FirstName + " " + user.LastName + " " + "(" + user.UserName + ")",
                                Value = user.Id.ToString()
                            }).ToList();
            ViewBag.userList = userList;
        }

        private void SelectCarList()
        {
            var cars = _carService.TGetAll();
            var carList = (from car in cars
                           orderby car.Brand.BrandName
                            select new SelectListItem
                            {
                                Text = car.Brand.BrandName + " " + car.ModelName + " " + car.Year,
                                Value = car.CarId.ToString()
                            }).ToList();
            ViewBag.carList = carList;
        }

        public IActionResult CreateReview()
        {
            SelectUserList();
            SelectCarList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateReview(CreateReviewDto model)
        {
            var value = _mapper.Map<Review>(model);
            _reviewService.TCreate(value);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateReview(int id)
        {
            SelectUserList();
            SelectCarList();
            var value = _reviewService.TGetById(id);
            var dtos = _mapper.Map<UpdateReviewDto>(value);
            return View(dtos);
        }

        [HttpPost]
        public IActionResult UpdateReview(UpdateReviewDto model)
        {
            var value = _mapper.Map<Review>(model);
            _reviewService.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteReview(int id)
        {
            _reviewService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
