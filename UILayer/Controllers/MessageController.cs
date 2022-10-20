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
            var mail = await _userManager.FindByEmailAsync(User.Identity.Name);
            ViewBag.mail = mail;
            //var values = _messageService.TGetReceiverMessageList(mail.ToString());
            return View();
        }

        public IActionResult Outbox()
        {
            return View();
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
