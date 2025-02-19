using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NETCORE_Lesson04.Models
{
    public class Member
    {
        public string Id { get; set; }

        //DisplayName - Nội dung hiển thị thay cho tên biến
        [DisplayName("Tên UserName")]
        //Required - Yêu cầu bắt buộc
        [Required(ErrorMessage ="UserName không được để trống")]
        //StringLength - Độ dài chuỗi
        [StringLength(20, MinimumLength =3 , ErrorMessage ="Username có độ dài từ 3-20 ký tự")]
        public string UserName { get; set; }


        //DisplayName - Nội dung hiển thị thay cho tên biến
        [DisplayName("Họ và tên")]
        //Required - Yêu cầu bắt buộc
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        //StringLength - Độ dài chuỗi
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Họ và tên có độ dài từ 3-20 ký tự")]
        public string FullName { get; set; }

        //Required - Yêu cầu bắt buộc
        [Required(ErrorMessage = "Email không được để trống")]
        // Kiểu dữ liệu là email
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Mật khẩu")]
        //Required - Yêu cầu bắt buộc
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        // Kiểu dữ liệu là email
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //DisplayName - Nội dung hiển thị thay cho tên biến
        [DisplayName("Số điện thoại")]
        //Required - Yêu cầu bắt buộc
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        //
        [RegularExpression(@"^0\d{9,12}$", ErrorMessage = "Sai định dạng số điện thoại! Vui lòng thử lại")]
        public string Phone { get; set; }
        //DisplayName - Nội dung hiển thị thay cho tên biến
        [DisplayName("Ngày sinh")]
        public DateTime Birthday { get; set; }

    }
}
