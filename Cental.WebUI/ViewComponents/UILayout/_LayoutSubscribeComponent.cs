using Cental.DtoLayer.UserDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.UILayout
{
    public class _LayoutSubscribeComponent : ViewComponent
    {
        public IViewComponentResult Invoke(UserRegisterDto model)
        {
            return View(model);
        }
    }
}
