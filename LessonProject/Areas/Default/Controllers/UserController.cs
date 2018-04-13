using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LessonProject.Controllers;
using LessonProject.Model;

namespace LessonProject.Areas.Default.Controllers
{
    public class UserController : BaseController
    {
        public ActionResult Index()
        {
            var users = Repository.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public ActionResult Register()
        {
            var newUser = new User();
            return View(newUser);
        }

        //[HttpGet]
        //public ActionResult Register()
        //{
        //    var newUser = new User();
        //    return View(newUser);
        //}

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (user.Captcha != "1234")
            {
                ModelState.AddModelError("Captcha", "Текст с картинки введен не верно");
            }

            var anyUser = Repository.Users.Any(p => string.Compare(p.Email, user.Email) == 0);

            if (anyUser)
            {
                ModelState.AddModelError("Email", "Пользователь с таким email уже зарегистрирован");
            }

            return View(user);
        }

    }
}