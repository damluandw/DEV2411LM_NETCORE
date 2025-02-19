using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesson02.Models;
namespace NETCORE_Lesson02.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke( int? n)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(1,"Cate1","Cate1"),
                new Category(2,"Cate2","Cate2"),
                new Category(3,"Cate3","Cate3"),
            };
            if(n != null)
            {
                var search = categories.Where(x => x.Id == n);
                return View(search);

            }
            else
            {
                return View(categories);
            }
            
        }

    }
}
