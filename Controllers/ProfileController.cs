using Microsoft.AspNetCore.Mvc;


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