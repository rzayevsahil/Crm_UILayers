using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;
        public MessageController(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }
        public async Task<IActionResult> Inbox()
        {
            var mail = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.mail = mail.Email;
            var values = _messageService.TGetReceiverMessageList(mail.Email);
            return View(values);
        }

        public async Task<IActionResult> Outbox()
        {
            var mail = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.mail = mail.Email;
            var values = _messageService.TGetSenderMessageList(mail.Email);
            return View(values);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message p)
        {
            return View();
        }

        public IActionResult MessageDetails(int id)
        {
            return View();
        }
    }
}
