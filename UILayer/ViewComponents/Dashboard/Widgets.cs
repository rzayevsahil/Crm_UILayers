using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents.Dashboard
{
    public class Widgets : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.categoriesCount = context.Categories.Count();
            ViewBag.productCount = context.Products.Count();
            return View();
        }
    }
}