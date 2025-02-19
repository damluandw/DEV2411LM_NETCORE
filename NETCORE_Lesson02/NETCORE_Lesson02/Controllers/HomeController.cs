using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesson02.Models;
using System.Diagnostics;

namespace NETCORE_Lesson02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            GetProduct();
            GetProduct1();
            return View();
        }

        public IActionResult Privacy()
        {
            GetProduct();
            GetProduct1();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public PartialViewResult GetProduct()
        {
            List<Product> products = new List<Product>()
            {
                new Product(1,"sp1", "thực phẩm chức năng 2", 120000),
                new Product(2,"sp3", "đồ gia dụng 2", 100000),
                new Product(3,"sp1", "mỹ phẩm 2", 500000),
            };
            return PartialView("_ProductsPartialView", products);
        }


        public PartialViewResult GetProduct1()
        {
            //List<Product> products = new List<Product>()
            //{
            //    new Product(1,"sp1", "thực phẩm chức năng", 120000),
            //    new Product(2,"sp3", "đồ gia dụng", 100000),
            //    new Product(3,"sp1", "mỹ phẩm", 500000),
            //};
            return PartialView("_Products1PartialView");
        }
    }
}
