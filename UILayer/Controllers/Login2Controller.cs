using System;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UILayer.Models;

namespace UILayer.Controllers
{
    public class Login2Controller : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public Login2Controller(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInModel userSignInModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByNameAsync(userSignInModel.UserName);
                if (await _userManager.IsLockedOutAsync(appUser))
                {
                    ModelState.AddModelError("", "Hesabınız keçici olarak kapanmıştır");
                    return View();
                }

                var result = await _signInManager.PasswordSignInAsync(appUser, userSignInModel.Password, false, true);
                if (result.Succeeded)
                {
                    await _userManager.ResetAccessFailedCountAsync(appUser);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    await _userManager.AccessFailedAsync(appUser);
                    int failedCounter = await _userManager.GetAccessFailedCountAsync(appUser);
                    ModelState.AddModelError("", $"Başarısız giriş sayısı: {failedCounter}");
                    if (failedCounter == 3)
                    {
                        await _userManager.SetLockoutEndDateAsync(appUser,
                            new DateTimeOffset(DateTime.Now.AddHours(5)));
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Lütfen kullanıcı adı veya şifre giriniz");
            }
            return View();
        }
    }
}
