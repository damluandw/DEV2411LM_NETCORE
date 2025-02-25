using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NETCORE_Lesson07.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Tên đăng nhập không để trống")]
        [DisplayName("Tên đăng nhập")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không để trống")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }


        public bool Remember {  get; set; }
    }
}
