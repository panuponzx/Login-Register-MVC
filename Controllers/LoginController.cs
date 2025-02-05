﻿using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using Microsoft.EntityFrameworkCore;
using YourNamespacex.Models;

namespace YourNamespace.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("/Views/Login/Login.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    // ล็อกอินสำเร็จ
                    // ทำการเก็บข้อมูลผู้ใช้ใน session หรือ authentication cookie ตามที่คุณต้องการ
                    return RedirectToAction("profile", "Profile");
                }
                else
                {
                    // ส่งข้อความแจ้งเตือนผ่าน TempData
                    TempData["ErrorMessage"] = "ไม่พบบัญชีผู้ใช้ กรุณาตรวจสอบอีเมลและรหัสผ่านอีกครั้ง";
                    return View("/Views/Login/Login.cshtml", model);
                }
            }
            return View("/Views/Login/Login.cshtml", model);
        }
    }
}