using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Models;
using HW4.Helpers;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetData(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Email == null || user.Name == null)
                {
                    return Content("false");
                }
                UserStorage.Users.Add(user);
                return Content("true");
            }
            return Content("false");
           
        }

        public IActionResult UserRegistration()
        {
            return View(UserStorage.Users.Last());
        }
    }
}
