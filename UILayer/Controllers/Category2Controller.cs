using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UILayer.Controllers
{
    public class Category2Controller : Controller
    {
        private readonly ICategoryService _categoryService;

        public Category2Controller(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListCategory()
        {
            var values = JsonConvert.SerializeObject(_categoryService.TGetListAll());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            var values = JsonConvert.SerializeObject(category);
            return Json(values);
        }

        public IActionResult GetByID(int categoryId)
        {
            var v = _categoryService.TGetByID(categoryId);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteCategory(int id)
        {
            var v = _categoryService.TGetByID(id);
            _categoryService.TDelete(v);
            return NoContent();
        }

        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            var values = JsonConvert.SerializeObject(category);
            return Json(values);
        }
    }
}

