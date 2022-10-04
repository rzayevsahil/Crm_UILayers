using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
