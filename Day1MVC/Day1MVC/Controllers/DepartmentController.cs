using Day1MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1MVC.Controllers
{
    public class DepartmentController : Controller
    {
       static List<Deparment> deparments = new List<Deparment>();
        static DepartmentController() {

           
            deparments.Add(new Deparment { DeptId = 101, DeptName ="CSE", DeptDescription = "Morning batch",DeptStrength = 120 });
            deparments.Add(new Deparment { DeptId = 102, DeptName = "IT", DeptDescription = "Morning/Evening batch", DeptStrength = 180 });
            deparments.Add(new Deparment { DeptId = 103, DeptName = "AIDS", DeptDescription = "Morning batch", DeptStrength = 60 });
            deparments.Add(new Deparment { DeptId = 104, DeptName = "MECH", DeptDescription = "Morning/Evening batch", DeptStrength = 240 });

        }

        
       //display Department
        public IActionResult GetDepartment()
        {
            return View(deparments);
        }

        //Add new Department

       public IActionResult AddDepartment()
        {
            deparments.Add(new Deparment { DeptId = 105, DeptName = "ECE", DeptDescription = "Morning/Evening batch", DeptStrength = 240 });
            return View("~/Views/Department/GetDeparment.cshtml");

        }

        //Display the department whose batch strength is 120

        public IActionResult GetDepartmentByBatchStrength()
        {
            var departmentData = (from department in deparments
                        where department.DeptStrength > 120
                        select department).ToList();

            return View(departmentData);
        }

}
}
