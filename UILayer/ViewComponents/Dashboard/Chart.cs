using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents.Dashboard
{
    public class Chart : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
