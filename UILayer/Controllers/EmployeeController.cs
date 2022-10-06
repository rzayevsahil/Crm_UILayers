using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using FluentValidation.Results;

namespace UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            var values = _employeeService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            ValidationResult result = validationRules.Validate(employee);
            employee.EmployeeBirth = Convert.ToDateTime("22.09.2000");
            if (result.IsValid)
            {
                _employeeService.TInsert(employee);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }

                return View();
            }
        }
    }
}
