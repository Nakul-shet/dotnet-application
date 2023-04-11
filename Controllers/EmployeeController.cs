using coreMvcArcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcArcProject.Controllers
{
    public class EmployeeController : Controller
    {

        public static List<Employee> employees = new List<Employee>() {

            new Employee() { Id = 101, Name = "Andrew" , Designation = "Manager" , Salary = 10000},
            new Employee() { Id = 102, Name = "Brandon" , Designation = "Developer" , Salary = 20000},
            new Employee() { Id = 103, Name = "Catelyn" , Designation = "Programmer" , Salary = 30000},
            new Employee() { Id = 104, Name = "Drake" , Designation = "Designer" , Salary = 40000}

        };
        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee person)
        {
            employees.Add(person);
            return RedirectToAction("Index");
        }
    }
}
