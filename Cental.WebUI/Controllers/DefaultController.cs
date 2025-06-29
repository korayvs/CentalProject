using Cental.BusinessLayer.Abstract;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController(IBookingService _bookingService, UserManager<AppUser> _userManager) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserAuthenticated = User.Identity.IsAuthenticated;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookingCarAsync(Booking model)
        {
            if (string.IsNullOrEmpty(User.Identity.Name))
            {
                ModelState.AddModelError(" ", "Lütfen rezervasyon işlemi için giriş yapın");
                return RedirectToAction("Index");
            }

            model.Status = "Beklemede";
            model.IsApproved = null;
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            model.UserId = user.Id;
            _bookingService.TCreate(model);
            return RedirectToAction("Index");
        }
    }
}
