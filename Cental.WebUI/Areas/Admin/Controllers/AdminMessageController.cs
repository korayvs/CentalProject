using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.MessageDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminMessageController(IMessageService _messageService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _messageService.TGetAll();
            var dtos = _mapper.Map<List<ResultMessageDto>>(values);
            return View(dtos);
        }

        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto model)
        {
            var value = _mapper.Map<Message>(model);
            _messageService.TCreate(value);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMessage(int id)
        {
            _messageService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult DetailMessage(int id)
        {
            var value = _messageService.TGetById(id);
            var dto = _mapper.Map<DetailMessageDto>(value);
            return View(dto);
        }
    }
}
