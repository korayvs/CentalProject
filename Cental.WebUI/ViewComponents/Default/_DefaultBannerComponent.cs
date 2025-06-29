using Cental.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultBannerComponent(IBannerService _bannerService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = _bannerService.TGetAll();
            return View(value);
        }
    }
}
