using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesson10_Authen_Custom.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace NETCORE_Lesson10_Authen_Custom.Controllers
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
            return View();
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (model.Email != "admin@gmail.com" || model.Password != "12345")
            {
                ModelState.AddModelError(string.Empty, "Tài khoản không hợp lệ");
                return View();
            }
            //xử lý lưu vào coockie
            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.Email) }, "DevSecurity");
            var priciple = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync("DevSecurity", priciple);

            return RedirectToAction("Index", "Admin");
        }

        public  IActionResult Logout()
        {
            HttpContext.SignOutAsync();         
            return RedirectToAction("Index", "Home");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
