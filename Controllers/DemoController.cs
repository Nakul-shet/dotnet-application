using coreMvcArcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcArcProject.Controllers
{
    public class DemoController : Controller
    {

        public static string[] Names = { "King", "Kochar", "Sarah", "Bowling" };

        public static List<Person> persons = new List<Person>() {

            new Person() { Id = 101, Name = "Andrew" , Age = 23 , City = "London"},
            new Person() { Id = 102, Name = "Brandon" , Age = 27 , City = "New York"},
            new Person() { Id = 103, Name = "Catelyn" , Age = 30 , City = "Dallas"},
            new Person() { Id = 104, Name = "Drake" , Age = 35 , City = "USA"}

        };
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome Everyone";
            ViewBag.Names = Names;
            ViewBag.PersonList = persons;
            ViewBag.TotalPersons = persons.Count();
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Welcome Everyone";
            ViewData["Names"] = Names;
            ViewData["PersonList"] = persons;
            ViewData["TotalPersons"] = persons.Count();
            return View();
        }

        public IActionResult Home()
        {
            TempData["name"] = "King Kochawr";
            return View();
        }

        public IActionResult About()
        {
            if (TempData.ContainsKey("name"))
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
