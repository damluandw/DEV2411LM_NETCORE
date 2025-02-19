using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NETCORE_Lesson06_CodeFirst.Models.DataModels
{
    public class Publisher
    {
        [DisplayName("Mã nhà xuất bản")]
        [StringLength(10)]
        public string PublisherId { get; set; }

        [DisplayName("Tên nhà xuất bản")]
        [StringLength(255)]
        public string Title { get; set; }


        [DisplayName("Địa chỉ")]
        [StringLength(255)]
        public string Address { get; set; }

        [DisplayName("Số điện thoại")]
        [StringLength(20)]
        public string Phone { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
