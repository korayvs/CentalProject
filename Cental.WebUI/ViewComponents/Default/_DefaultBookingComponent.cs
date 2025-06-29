using Cental.BusinessLayer.Abstract;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultBookingComponent(IBookingService _bookingService, ICarService _carService, IBannerService _bannerService) : ViewComponent
    {
        public IViewComponentResult Invoke(Booking model)
        {
            var carList = (from car in _carService.TGetAll()
                           select new SelectListItem
                           {
                               Text = car.Brand.BrandName + " " + car.ModelName + " " + car.Year,
                               Value = car.CarId.ToString()
                           }).ToList();
            ViewBag.carList = carList;
            return View(model ?? new Booking());
        }
    }
}
