using System.ComponentModel.DataAnnotations;

namespace YourNamespacex.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "กรุณากรอกอีเมล")]
        [EmailAddress(ErrorMessage = "รูปแบบอีเมลไม่ถูกต้อง")]
        public string Email { get; set; }

        [Required(ErrorMessage = "กรุณากรอกรหัสผ่าน")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}