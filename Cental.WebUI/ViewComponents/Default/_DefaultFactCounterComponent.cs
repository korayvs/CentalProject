using Cental.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultFactCounterComponent(IFactCounterService _factCounterService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.UserCount = _factCounterService.TUserCount();
            ViewBag.CarCount = _factCounterService.TCarCount();
            ViewBag.BookingCount = _factCounterService.TBookingCount();
            ViewBag.ReviewCount = _factCounterService.TReviewCount();
            return View();
        }
    }
}
