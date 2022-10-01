using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UILayer.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values = productManager.TGetListProductWithCategory();
            return View(values);
        }
         
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in categoryManager.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.values = values; 
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productManager.TInsert(product);
            return RedirectToAction("Index");
        }
    }
}
