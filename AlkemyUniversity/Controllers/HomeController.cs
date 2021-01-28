using AlkemyUniversity.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlkemyUniversity.Controllers
{
    public class HomeController : Controller
    {
        private UniversityContext db = new UniversityContext();

        [Authorize(Roles = "Student")]
        public ActionResult Index()
        {
            var courses = db.Courses.OrderBy(t => t.Title).ToList();
            return View(courses);
        }



    }
}