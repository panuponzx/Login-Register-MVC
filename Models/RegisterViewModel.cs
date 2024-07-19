using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class RegisterViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณากรอกชื่อผู้ใช้")]
        public string Username { get; set; }

        [Required(ErrorMessage = "กรุณากรอกอีเมล")]
        [EmailAddress(ErrorMessage = "รูปแบบอีเมลไม่ถูกต้อง")]
        public string Email { get; set; }

        [Required(ErrorMessage = "กรุณากรอกรหัสผ่าน")]
        [StringLength(100, ErrorMessage = "รหัสผ่านต้องมีความยาวอย่างน้อย {2} ตัวอักษร", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์")]
        [Phone(ErrorMessage = "รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง")]
        public string PhoneNumber { get; set; }
    }
}