using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesson03.Models.DataModels;

namespace NETCORE_Lesson03.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>()
            {
                new Member(1,"Devmater","test 1", "094832744","25 Vũ Ngọc Phan", "Hà Nội", "VN"),
                new Member(2,"Lê Quốc Vương","SV", "0921332245","25 Vũ Ngọc Phan", "Hà Nội", "VN"),
                new Member(3,"Quân","SV", "0656454654","25 Vũ Ngọc Phan", "Hà Nội", "VN"),
                new Member(4,"Hải","SV", "06552131","25 Vũ Ngọc Phan", "Hà Nội", "VN")
            };
        public IActionResult Index()
        {
            Member member = new Member();
            member.Id = 1;
            member.Name = "Devmaster";
            member.Address = "25 Vũ Ngọc Phan";
            member.City = "Hà Nội";
            member.Phone = "09999999";
            member.Region = "VN";
            member.Description = "Test";
            ViewBag.Member = member;
            return View();
        }

        public IActionResult Index1()
        {
            Member member = new Member();
            member.Id = 1;
            member.Name = "Devmaster";
            member.Address = "25 Vũ Ngọc Phan";
            member.City = "Hà Nội";
            member.Phone = "09999999";
            member.Region = "VN";
            member.Description = "Test";
            return View(member);
        }

        public IActionResult GetMembers()        {
            
            ViewBag.members = members;
            return View();
        }
        public IActionResult List()
        {
            return View(members);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            members.Add(member);
            return RedirectToAction("List");
        }
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            
            var member = members.Where(members => members.Id == id).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            for (int i = 0;i< members.Count; i++)
            {
                if (members[i].Id == member.Id)
                {
                    members[i] = member;
                    break;
                }
            }
            return RedirectToAction("List");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var member = members.Where(members => members.Id == id).FirstOrDefault();
            return View(member);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var member = members.Where(members => members.Id == id).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult Delete(Member member)
        {
            members = members.Where(members => members.Id != member.Id).ToList();
            return RedirectToAction("List");
        }
    }
}
