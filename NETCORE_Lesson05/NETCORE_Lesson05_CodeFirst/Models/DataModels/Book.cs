using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace NETCORE_Lesson05_CodeFirst.Models.DataModels
{
    [Table("Books")]
    public class Book
    {
        [DisplayName("Mã Sách")]
        [StringLength(10)]
        public string BookId { get; set; }

        [DisplayName("Tên sách")]
        [StringLength(255)]
        public string Title { get; set; }

        [DisplayName("Tên tác giả")]
        [StringLength(255)]
        public string Author { get; set; }

        [DisplayName("Năm xuất bản")]
        public int? Release{ get; set; }

        [DisplayName("Mô tả")]
        [StringLength(255)]
        public string Note { get; set; }
        [DisplayName("Hình ảnh")]
        [StringLength(255)]
        public string Image { get; set; }
        [DisplayName("Nhà xuất bản")]
        [StringLength(255)]
        public string PublisherId { get; set; }
        [DisplayName("Nhà xuất bản")]
        [StringLength(255)]
        public string CategoryId { get; set; }

        public Category Category { get; set; }

        public Publisher Publisher { get; set; }
    }
}
