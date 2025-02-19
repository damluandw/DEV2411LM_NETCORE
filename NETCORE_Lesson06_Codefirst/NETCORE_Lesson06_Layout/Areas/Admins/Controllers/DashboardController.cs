using Microsoft.AspNetCore.Mvc;

namespace NETCORE_Lesson06_Layout.Areas.Admins.Controllers
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
