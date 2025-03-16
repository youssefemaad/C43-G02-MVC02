using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        //BaseURL/Home/Index
        public IActionResult Index()
        {
            return View();
        }

        //BaseURL/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        //BaseURL/Home/AboutUs
        public IActionResult AboutUs()
        {
            return View();
        }

        //BaseURL/Home/Contact
        public IActionResult Contact()
        {
            return View();
        }
    }
}
