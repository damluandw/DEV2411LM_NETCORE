using Microsoft.AspNetCore.Mvc;

namespace NETCORE_Lesson07.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
