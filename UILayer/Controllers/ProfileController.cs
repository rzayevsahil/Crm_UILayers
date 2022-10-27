using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
