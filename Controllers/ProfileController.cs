using Microsoft.AspNetCore.Mvc;
using WebApplication_bas.Controllers;

namespace WebApplication_bas.Controllers
{

    [Route("/Profile")]
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
