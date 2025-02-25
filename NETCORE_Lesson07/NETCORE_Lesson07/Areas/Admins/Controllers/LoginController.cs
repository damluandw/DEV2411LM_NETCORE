using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesson07.Models;
using NETCORE_Lesson07.Models.DBModel;
using System.Security.Cryptography;
using System.Text;

namespace NETCORE_Lesson07.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class LoginController : Controller
    {
        private readonly DatabaseFirstContext _context;
        public LoginController(DatabaseFirstContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            
            var password = GetSha256Hash(model.Password);
            var login = _context.Adminusers.FirstOrDefault(user=> user.UserName == model.UserName && user.Password == password);

            if(login != null)
            {
                HttpContext.Session.SetString("AdminLogin", model.UserName);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            //Xóa Session
            HttpContext.Session.Remove("AdminLogin");
            return RedirectToAction("Index");
        }


        string GetSha256Hash(string rawData)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
