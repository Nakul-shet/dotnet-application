using Microsoft.AspNetCore.Mvc;

namespace coreMvcArcProject.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action method";
        }

        //Request Url : http://localhost:5063/HelloWorld/Welcome
        //Request Url : http://localhost:5063/HelloWorld/Welcome?name=Nakul
        //Request Url : http://localhost:5063/HelloWorld/Welcome?name=Nakul&age=21

        public string Welcome(string name = "Nakul" , int age = 21)
        {
            /*return "This is my welcome action method";*/
            return $"Hello {name} , your age is {age}";
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Details()
        {
            return View("DetailsPage");
        }
    }
}
