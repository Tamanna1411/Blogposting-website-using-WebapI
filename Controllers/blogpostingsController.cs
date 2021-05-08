using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogAPI.Models;

namespace BlogAPI.Controllers
{
    public class blogpostingsController : Controller
    {
        private blogEntities db = new blogEntities();

        // GET: blogpostings
        public ActionResult Index()
        {
            return View(db.blogpostings.ToList());
        }

        // GET: blogpostings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blogposting blogposting = db.blogpostings.Find(id);
            if (blogposting == null)
            {
                return HttpNotFound();
            }
            return View(blogposting);
        }

        // GET: blogpostings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: blogpostings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Tags,Content")] blogposting blogposting)
        {
            if (ModelState.IsValid)
            {
                db.blogpostings.Add(blogposting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogposting);
        }

        // GET: blogpostings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blogposting blogposting = db.blogpostings.Find(id);
            if (blogposting == null)
            {
                return HttpNotFound();
            }
            return View(blogposting);
        }

        // POST: blogpostings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Tags,Content")] blogposting blogposting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogposting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogposting);
        }

        // GET: blogpostings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            blogposting blogposting = db.blogpostings.Find(id);
            if (blogposting == null)
            {
                return HttpNotFound();
            }
            return View(blogposting);
        }

        // POST: blogpostings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            blogposting blogposting = db.blogpostings.Find(id);
            db.blogpostings.Remove(blogposting);
            db.SaveChanges();
            return RedirectToAction("Index");
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
