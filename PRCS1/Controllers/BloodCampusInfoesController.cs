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
    public class BloodCampusInfoesController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: BloodCampusInfoes
        public ActionResult Index(string searchString)
        {
            var movies = from m in db.CampusInfo
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.BloodCampus.Contains(searchString));
            }

            return View(movies);

        }

        // GET: BloodCampusInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodCampusInfo bloodCampusInfo = db.CampusInfo.Find(id);
            if (bloodCampusInfo == null)
            {
                return HttpNotFound();
            }
            return View(bloodCampusInfo);
        }

        // GET: BloodCampusInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloodCampusInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StartTime,BloodCampus,OrganizedDate,InstituteName,InstituteAddress,InstituteDistrict,DeansContact,SocietyContact,NoOfBags")] BloodCampusInfo bloodCampusInfo)
        {
            if (ModelState.IsValid)
            {
                db.CampusInfo.Add(bloodCampusInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloodCampusInfo);
        }

        // GET: BloodCampusInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodCampusInfo bloodCampusInfo = db.CampusInfo.Find(id);
            if (bloodCampusInfo == null)
            {
                return HttpNotFound();
            }
            return View(bloodCampusInfo);
        }

        // POST: BloodCampusInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StartTime,BloodCampus,OrganizedDate,InstituteName,InstituteAddress,InstituteDistrict,DeansContact,SocietyContact,NoOfBags")] BloodCampusInfo bloodCampusInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloodCampusInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloodCampusInfo);
        }

        // GET: BloodCampusInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodCampusInfo bloodCampusInfo = db.CampusInfo.Find(id);
            if (bloodCampusInfo == null)
            {
                return HttpNotFound();
            }
            return View(bloodCampusInfo);
        }

        // POST: BloodCampusInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BloodCampusInfo bloodCampusInfo = db.CampusInfo.Find(id);
            db.CampusInfo.Remove(bloodCampusInfo);
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
