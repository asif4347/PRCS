using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRCS.Models;
using PRCS1.Models;

namespace PRCS1.Controllers
{
    [Authorize]
    public class ThalassimiaInfoesController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: ThalassimiaInfoes
        public ActionResult Index()
        {
            return View(db.Thalassimia.ToList());
        }

        // GET: ThalassimiaInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThalassimiaInfo thalassimiaInfo = db.Thalassimia.Find(id);
            if (thalassimiaInfo == null)
            {
                return HttpNotFound();
            }
            return View(thalassimiaInfo);
        }

        // GET: ThalassimiaInfoes/Create
        public ActionResult Create(int? id)
        {

            db.BloodInfo.Find(id).isSelected = "Selected";
            db.BloodInfo.Find(id).LastDonation = DateTime.Now;
            db.BloodInfo.Find(id).NoOfDonation++;
            db.SaveChanges();
            return View();
        }

        // POST: ThalassimiaInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Contact,ThelesemiaStatus,RegOrIrreg")] ThalassimiaInfo thalassimiaInfo)
        {
            if (ModelState.IsValid)
            {
                db.Thalassimia.Add(thalassimiaInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thalassimiaInfo);
        }

        // GET: ThalassimiaInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThalassimiaInfo thalassimiaInfo = db.Thalassimia.Find(id);
            if (thalassimiaInfo == null)
            {
                return HttpNotFound();
            }
            return View(thalassimiaInfo);
        }

        // POST: ThalassimiaInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Contact,ThelesemiaStatus,RegOrIrreg")] ThalassimiaInfo thalassimiaInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thalassimiaInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thalassimiaInfo);
        }

        // GET: ThalassimiaInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThalassimiaInfo thalassimiaInfo = db.Thalassimia.Find(id);
            if (thalassimiaInfo == null)
            {
                return HttpNotFound();
            }
            return View(thalassimiaInfo);
        }

        // POST: ThalassimiaInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThalassimiaInfo thalassimiaInfo = db.Thalassimia.Find(id);
            db.Thalassimia.Remove(thalassimiaInfo);
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
