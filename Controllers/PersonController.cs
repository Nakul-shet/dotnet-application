using coreMvcArcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcArcProject.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> persons = new List<Person>() {

            new Person() { Id = 101, Name = "Andrew" , Age = 23 , City = "London"},
            new Person() { Id = 102, Name = "Brandon" , Age = 27 , City = "New York"},
            new Person() { Id = 103, Name = "Catelyn" , Age = 30 , City = "Dallas"},
            new Person() { Id = 104, Name = "Drake" , Age = 35 , City = "USA"}

        };

        public IActionResult Index()
        {
            return View(persons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            persons.Add(person);
            return RedirectToAction("Index");
        }
    }
}
