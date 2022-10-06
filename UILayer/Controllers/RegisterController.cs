using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UILayer.Models;

namespace UILayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpModel userSignUpModel)
        {
            //if (ModelState.IsValid)
            //{
            //işlemi yap
            AppUser user = new AppUser()
            {
                Email = userSignUpModel.Mail,
                Name = userSignUpModel.Name,
                Surname = userSignUpModel.Surname,
                Gender = userSignUpModel.Gender,
                UserName = userSignUpModel.Username
            };
            //}
            if (userSignUpModel.Password == userSignUpModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(user, userSignUpModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
