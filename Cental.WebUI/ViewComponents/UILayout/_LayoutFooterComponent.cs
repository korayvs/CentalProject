using Cental.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.UILayout
{
    public class _LayoutFooterComponent(IContactInfoService _contactInfoService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var contact = _contactInfoService.TGetAll().TakeLast(1).FirstOrDefault();
            return View(contact);
        }
    }
}
