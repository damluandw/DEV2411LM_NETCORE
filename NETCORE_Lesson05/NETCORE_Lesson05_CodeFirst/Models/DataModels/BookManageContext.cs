using Microsoft.EntityFrameworkCore;

namespace NETCORE_Lesson05_CodeFirst.Models.DataModels
{
    public class BookManageContext :DbContext
    {
        public  BookManageContext(DbContextOptions<BookManageContext> options): base(options)  { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publisher { get; set; }


    }
}
