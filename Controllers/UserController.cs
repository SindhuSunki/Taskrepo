using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="sam",UserPwd="sam@1256",UserEmail="sam@yahoo.com"},
            new User(){UserId=2,UserName="amit",UserPwd="amit@123",UserEmail="amit@hotmail.com"},
            new User(){UserId=3,UserName="kumar",UserPwd="kumar@1256",UserEmail="Kumar@yahoo.com"},
            new User(){UserId=4,UserName="anisha",UserPwd="a@rohan",UserEmail="a@mail.com"},
            new User(){UserId=5,UserName="vidhisha",UserPwd="v@isha",UserEmail="v5@gmail.com"}
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User Model)
        {
            if (ModelState.IsValid)
            {
                users.Add(Model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(Model);
            }
        }
    }
}
