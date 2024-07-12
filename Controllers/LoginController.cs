using Microsoft.AspNetCore.Mvc;
using WebApplication_bas.Models;

public class LoginController : Controller
{
    [HttpPost("/Login")]
    [Route("/Login")]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // ตรวจสอบข้อมูลจากฐานข้อมูลหรือระบบการยืนยันตัวตน
            // ในที่นี้จะเป็นตัวอย่างเท่านั้น

            if (model.Email == "user@example.com" && model.Password == "password")
            {
                // ในที่นี้เราจะให้เข้าสู่ระบบเสมอ
                return RedirectToAction("Login", "Profile"); // หรือไปยังหน้าที่ต้องการหลังจาก Login สำเร็จ
            }
            else
            {
                // กรณีที่ข้อมูลไม่ถูกต้อง
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
        }
        return View(model);
    }
}
