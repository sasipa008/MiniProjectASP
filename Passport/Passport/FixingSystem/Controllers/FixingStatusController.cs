using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FixingSystem.Models;

namespace FixingSystem.Controllers
{
    public class FixingStatusController : Controller
    {
        private FixingSystemContext db = new FixingSystemContext();

        // GET: FixingStatus
        public ActionResult Index()
        {
            return View(db.FixingStatus.ToList());
        }

        // GET: FixingStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixingStatus fixingStatus = db.FixingStatus.Find(id);
            if (fixingStatus == null)
            {
                return HttpNotFound();
            }
            return View(fixingStatus);
        }

        // GET: FixingStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FixingStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Date,DateTime,Room,Details,Status,Technician")] FixingStatus fixingStatus)
        {
            if (ModelState.IsValid)
            {
                db.FixingStatus.Add(fixingStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fixingStatus);
        }

        // GET: FixingStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixingStatus fixingStatus = db.FixingStatus.Find(id);
            if (fixingStatus == null)
            {
                return HttpNotFound();
            }
            return View(fixingStatus);
        }

        // POST: FixingStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Date,DateTime,Room,Details,Status,Technician")] FixingStatus fixingStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fixingStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fixingStatus);
        }

        // GET: FixingStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixingStatus fixingStatus = db.FixingStatus.Find(id);
            if (fixingStatus == null)
            {
                return HttpNotFound();
            }
            return View(fixingStatus);
        }

        // POST: FixingStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FixingStatus fixingStatus = db.FixingStatus.Find(id);
            db.FixingStatus.Remove(fixingStatus);
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
