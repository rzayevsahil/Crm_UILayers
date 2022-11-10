using System;
using System.IO;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UILayer.Models;

namespace UILayer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = user.Name + " " + user.Surname;
            ViewBag.gender = user.Gender;
            ViewBag.image = "/images/" + user.ImageUrl;
            ViewBag.mail = user.Email;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(AppUser appUser)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = appUser.Name;
            user.Surname = appUser.Surname;
            user.PhoneNumber = appUser.PhoneNumber;
            user.Gender = appUser.Gender;
            user.Email = appUser.Email;
            user.ImageUrl = appUser.ImageUrl;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, appUser.PasswordHash);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = user.Name;
            userEditViewModel.Surname = user.Surname;
            userEditViewModel.Phone = user.PhoneNumber;
            userEditViewModel.Email = user.Email;
            userEditViewModel.ImageUrl = user.ImageUrl;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.Password == userEditViewModel.ComfirmPassword)
            {
                if (userEditViewModel.Image != null)
                {
                    var resource = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(userEditViewModel.Image.FileName);
                    var imageName = Guid.NewGuid() + extension;
                    var saveLocation = resource + "/wwwroot/images/" + imageName;
                    var stream = new FileStream(saveLocation, FileMode.Create);
                    await userEditViewModel.Image.CopyToAsync(stream);
                    user.ImageUrl = imageName;
                }
                user.Name = userEditViewModel.Name;
                user.Surname = userEditViewModel.Surname;
                user.PhoneNumber = userEditViewModel.Phone;
                user.Email = userEditViewModel.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Şifreler birbiri ile uyuşmuyor");
            }
            return View();
        }
    }
}
