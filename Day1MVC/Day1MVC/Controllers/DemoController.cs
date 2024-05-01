using Day1MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Json
        public IActionResult DisplayEmployee()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Smith";
            employee.Email = "smith@gmail.com";
            return Json(employee);
        }

        //ViewResult
        public ViewResult DisplayName()
        {
            return View();
        }

    }
}
