using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.MessageDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController(IContactInfoService _contactInfoService, IMessageService _messageService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _contactInfoService.TGetAll().TakeLast(1).FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult SendMessage(CreateMessageDto model)
        {
            var value = _mapper.Map<Message>(model);
            _messageService.TCreate(value);
            return RedirectToAction("Index");
        }
    }
}
