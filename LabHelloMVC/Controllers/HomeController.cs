using System.Diagnostics;
using LabHelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabHelloMVC.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            Person person = new Person();
            person.FirstName = "Bob";
            person.LastName = "Smith";
            return View(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
