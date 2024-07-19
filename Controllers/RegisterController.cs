using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<RegisterController> _logger;

        public RegisterController(ApplicationDbContext context, ILogger<RegisterController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            _logger.LogInformation("Register page accessed.");
            return View("/Views/Login/Register.cshtml");
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Model is valid. Creating user.");
                var user = new User
                {
                    Username = model.Username,
                    Email = model.Email,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber
                };
                try
                {
                    var users = _context.Set<User>();
                    users.Add(user);
                    await _context.SaveChangesAsync();
                    _logger.LogInformation("User saved successfully.");
                    return RedirectToAction("Login", "Login");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error saving user: {ex.Message}");
                    ModelState.AddModelError("", "เกิดข้อผิดพลาดในการลงทะเบียน กรุณาลองอีกครั้ง");
                }
            }
            else
            {
                _logger.LogWarning("Model state is invalid.");
                // เพิ่มข้อความแจ้งเตือนทั่วไปสำหรับการกรอกข้อมูลไม่ครบ
                ModelState.AddModelError("", "กรุณากรอกข้อมูลให้ครบถ้วน");
            }

            // ส่งกลับ View พร้อมกับ model ที่มีข้อผิดพลาด
            return View("/Views/Login/Register.cshtml", model);
        }
    }
}