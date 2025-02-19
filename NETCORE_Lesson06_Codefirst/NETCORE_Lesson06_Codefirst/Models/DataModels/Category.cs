using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NETCORE_Lesson06_CodeFirst.Models.DataModels
{
    public class Category
    {
        [DisplayName("Mã danh mục")]
        [StringLength(10)]
        public string CategoryId { get; set; }

        [DisplayName("Tên danh mục")]
        [StringLength(255)]
        public string Title { get; set; }


        public ICollection<Book> Books { get; set; }
    }
}
