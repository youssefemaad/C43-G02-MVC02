using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class AccountController : Controller
    {
        //BaseURL/Home/Index
        public IActionResult SignIn()
        {
            return View();
        }

        //BaseURL/Home/Privacy
        public IActionResult Register()
        {
            return View();
        }
    }
}
