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
        public IActionResult Index(UserSignUpModel userSignUpModel)
        {
            if (ModelState.IsValid)
            {
                //işlemi yap
                AppUser user = new AppUser()
                {
                    Email = userSignUpModel.Mail,
                    Name = userSignUpModel.Name,
                    Surname = userSignUpModel.Surname,
                    Gender = userSignUpModel.Gender,
                    UserName = userSignUpModel.Username
                };
                //var result= await 
            }
            return View();
        }
    }
}
