using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LessonProject.Model;
using LessonProject.Models;
using Ninject;
using LessonProject.Controllers;

namespace LessonProject.Areas.Default.Controllers
{
    public class HomeController : BaseController
    {
       // [Inject]
        //public IWeapon weapon { get; set; }
       // public IRepository Repository { get; set; }

        public HomeController()
        {
            //weapon = DependencyResolver.Current.GetService<IWeapon>();
        }

        public ActionResult Index()
        {
            // return View(weapon);
            // var roles = Repository.Roles.ToList();
            // return View(roles);
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}