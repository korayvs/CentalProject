using Cental.BusinessLayer.Abstract;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminContactInfoController(IContactInfoService _contactInfoService) : Controller
    {
        public IActionResult Index()
        {
            var values = _contactInfoService.TGetAll();
            return View(values);
        }

        public IActionResult CreateContactInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContactInfo(ContactInfo model)
        {
            _contactInfoService.TCreate(model);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateContactInfo(int id)
        {
            var value = _contactInfoService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContactInfo(ContactInfo model)
        {
            _contactInfoService.TUpdate(model);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContactInfo(int id)
        {
            _contactInfoService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
