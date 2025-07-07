using Cental.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminDashboardController(IDashboardService _dashboardService) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TotalUserCount = _dashboardService.TTotalUserCount();
            ViewBag.TotalManagerCount = _dashboardService.TTotalManagerCount();
            ViewBag.TotalAdminCount = _dashboardService.TTotalAdminCount();
            ViewBag.TotalMessageCount = _dashboardService.TTotalMessageCount();
            ViewBag.TotalCarCount = _dashboardService.TTotalCarCount();
            ViewBag.TotalTestimonialCount = _dashboardService.TTotalTestimonialCount();
            ViewBag.TotalReviewCount = _dashboardService.TTotalReviewCount();
            ViewBag.TotalBrandCount = _dashboardService.TTotalBrandCount();
            ViewBag.LastAddedCars = _dashboardService.TLastAddedCars();
            ViewBag.MostCheapCar = _dashboardService.TMostCheapCar();
            ViewBag.MostExpensiveCar = _dashboardService.TMostExpensiveCar();
            ViewBag.MostSelectedCarName = _dashboardService.TMostSelectedCarName();
            ViewBag.LeastSelectedCarName = _dashboardService.TLeastSelectedCarName();
            ViewBag.TotalBookingCount = _dashboardService.TTotalBookingCount();
            ViewBag.WaitingBookingCount = _dashboardService.TWaitingBookingCount();
            ViewBag.ApprovedBookingCount = _dashboardService.TApprovedBookingCount();
            ViewBag.DeclineBookingCount = _dashboardService.TDeclineBookingCount();

            ViewBag.BookingList = _dashboardService.TGetBookings();
            ViewBag.LastAddedCars = _dashboardService.TLastAddedCars();
            ViewBag.MessageList = _dashboardService.TGetMessages();
            ViewBag.TestimonialList = _dashboardService.TGetTestimonials();

            var avr = _dashboardService.TGetTestimonialAvarage();
            ViewBag.GetTestimonialAvarage = Math.Round(avr, 2);

            return View();
        }
    }
}
