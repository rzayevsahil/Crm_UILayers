using Microsoft.AspNetCore.Mvc;

namespace Crm_UILayer.Controller
{
    public class Employee : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
