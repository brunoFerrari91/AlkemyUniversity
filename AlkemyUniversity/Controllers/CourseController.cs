using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AlkemyUniversity.DAL;
using AlkemyUniversity.Models;
using Microsoft.AspNet.Identity;

namespace AlkemyUniversity.Controllers
{
    public class CourseController : Controller
    {
        private UniversityContext db = new UniversityContext();

        // GET: Course

        [Authorize(Roles = "Admin")]
        public ActionResult IndexAdmin()
        {
            var courses = db.Courses.OrderBy(t => t.Title).ToList();
            return View(courses);
        }

        // GET: Course/Details/5
        [Authorize(Roles = "Student")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult DetailsAdmin(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        [Authorize(Roles = "Student")]
        public ActionResult Enroll(int id)
        {
            Course course = db.Courses.Find(id);
            if (course.Quota <= 0)
            {
                ViewBag.message = "This course is full";
               return View();
            }
            var userId = User.Identity.GetUserId();
            var enrollments= from c in db.Enrollments
                             where c.CourseID.Equals(id)
                             select c;            
            foreach (var e in enrollments)
            {
                if (e.StudentID == userId)
                {
                    ViewBag.message = "You are already enrolled in this course";
                    return View();
                }
            }           
            course.Quota -= 1;
            Enrollment enrollment = new Enrollment();
            enrollment.CourseID = id;
            enrollment.StudentID = userId;
            db.Enrollments.Add(enrollment);
            db.SaveChanges(); 
            ViewBag.message = "You have been succesfully enrolled in this course";
            return View();                    
        }

        // GET: Course/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseID,Title,Quota,Description")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("IndexAdmin");
            }

            return View(course);
        }

        // GET: Course/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseID,Title,Quota,Description")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IndexAdmin");
            }
            return View(course);
        }

        // GET: Course/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
            db.SaveChanges();
            return RedirectToAction("IndexAdmin");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
