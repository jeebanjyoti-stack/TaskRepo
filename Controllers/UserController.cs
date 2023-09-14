using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User()
            {
                UserId = 1,UserName="sam",UserPwd="sam@1256",UserEmail="sam@yahoo.com"
            },
             new User()
            {
                UserId = 2,UserName="Harry",UserPwd="harry@1256",UserEmail="harry@yahoo.com"
            },
             new User()
            {
                UserId = 3,UserName="Dev",UserPwd="dev@1256",UserEmail="dev@yahoo.com"
            },
             new User()
            {
                UserId = 4,UserName="Mrunal",UserPwd="mrunal@1256",UserEmail="mrunal@yahoo.com"
            },
             new User()
            {
                UserId = 5,UserName="Vicky",UserPwd="vicky@1256",UserEmail="vicky@yahoo.com"
            },

        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
            
        }

    }
}
