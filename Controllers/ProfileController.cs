using Microsoft.AspNetCore.Mvc;

namespace WebApplication_bas.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
