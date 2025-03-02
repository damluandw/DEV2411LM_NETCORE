using System.ComponentModel.DataAnnotations;

namespace NETCORE_Lesson10_Authen_Custom.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Email không được để trống")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}
