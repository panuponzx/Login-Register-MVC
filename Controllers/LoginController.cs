using Microsoft.AspNetCore.Mvc;
using WebApplication_bas.Models;

namespace WebApplication_bas.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
             
                return RedirectToAction("Login", "Login");
            }

            return View(model);
        }
    }
}
