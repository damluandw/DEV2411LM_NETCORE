using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesson04.Models;
using System.Text.RegularExpressions;

namespace NETCORE_Lesson04.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>();
        // GET: HomeController1
        public ActionResult Index()
        {
            return View(members);
        }
        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            var check = true;
            string msg = "";
            if(member.UserName.Length <3 || member.UserName.Length> 20)
            {
                check = false;
                msg = "<p>UserName phải lớn hơn 3 ký tự và nhỏ hơn 20 ký tự</p>";
            }

            if (member.FullName.Length < 3 || member.FullName.Length > 20)
            {
                check = false;
                msg += "<p> FullName phải lớn hơn 3 ký tự và nhỏ hơn 20 ký tự </p>";
            }
            var regxEmail = "^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+\\.[a-zA-Z]{2,}$";
            if(!Regex.IsMatch(member.Email, regxEmail))
            {
                check = false;
                msg += "<p>Email chưa đúng định dạng vui lòng thử lại</p>";
            }
            if (check)
            {

                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.msg = "<div class=\"text-danger\">"+ msg+"</div>" ;
            }
            return View();
            
        }

        public ActionResult Create2()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2(Member member)
        {
            if (ModelState.IsValid)
            {
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }

            return View();

        }
        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
