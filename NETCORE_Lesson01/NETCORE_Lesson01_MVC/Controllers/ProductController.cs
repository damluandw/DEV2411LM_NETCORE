using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesson01_MVC.Models;

namespace NETCORE_Lesson01_MVC.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListProduct()
        {
            products = new List<Product>()
            {
                   new Product(1,"SP1","Sản phẩm làm đẹp", 20000),
                   new Product(12,"SP2","Sản phẩm tiêu dùng", 40000),
                   new Product(3,"SP3","Sản phẩm gia đình", 50000),
            };
            Product product = new Product();
            product.Id = 13;
            product.Name = "Sản phẩm 2";
            product.Description = "Sản phẩm nông nghiệp";
            product.Price = null;
            products.Add(product);
            products[3].Price = null;
            ViewBag.Products = products;
            return View();
        }

        public IActionResult ListProduct2()
        {
            products = new List<Product>()
            {
                   new Product(1,"SP1","Sản phẩm làm đẹp", 20000),
                   new Product(12,"SP2","Sản phẩm tiêu dùng", 40000),
                   new Product(3,"SP3","Sản phẩm gia đình", 50000),
            };         
            ViewData["Products"] = products;
            return View();
        }
        [Route("demo")]
        public IActionResult DemoDuLieu()
        {
            ViewData["viewData"] = "Dữ liệu được truyền qua viewData";
            ViewBag.viewBag = "Dữ liệu được truyền qua viewBag";
            TempData["tempData"] = "Dữ liệu được truyền qua tempData";
            return View();
        }
    }
}
