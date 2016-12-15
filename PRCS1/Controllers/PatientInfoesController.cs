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
    public class PatientInfoesController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: PatientInfoes
        public ActionResult Index()
        {
            return View(db.patientInfo.ToList());
        }

        // GET: PatientInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientInfo patientInfo = db.patientInfo.Find(id);
            if (patientInfo == null)
            {
                return HttpNotFound();
            }
            return View(patientInfo);
        }

        // GET: PatientInfoes/Create
        public ActionResult Create(string dNo)
        {
            return View();
        }

        // POST: PatientInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PatientName,PresBy,Cause,crossMatch,issueDate,StartTime,AdverseReaction,Details")] PatientInfo patientInfo)
        {
            if (ModelState.IsValid)
            {
                
               // db.patientInfo.Add()
                db.patientInfo.Add(patientInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientInfo);
        }

        // GET: PatientInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientInfo patientInfo = db.patientInfo.Find(id);
            if (patientInfo == null)
            {
                return HttpNotFound();
            }
            return View(patientInfo);
        }

        // POST: PatientInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PatientName,PresBy,Cause,crossMatch,issueDate,StartTime,AdverseReaction,Details")] PatientInfo patientInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientInfo);
        }

        // GET: PatientInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientInfo patientInfo = db.patientInfo.Find(id);
            if (patientInfo == null)
            {
                return HttpNotFound();
            }
            return View(patientInfo);
        }

        // POST: PatientInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientInfo patientInfo = db.patientInfo.Find(id);
            db.patientInfo.Remove(patientInfo);
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
