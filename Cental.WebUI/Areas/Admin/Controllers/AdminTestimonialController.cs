using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminTestimonialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
