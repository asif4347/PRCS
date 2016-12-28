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
    public class BloodBankTestsController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: BloodBankTests
        public ActionResult Index()
        {
            return View(db.BloodBank.ToList());
        }

        // GET: BloodBankTests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodBankTest bloodBankTest = db.BloodBank.Find(id);
            if (bloodBankTest == null)
            {
                return HttpNotFound();
            }
            return View(bloodBankTest);
        }

        // GET: BloodBankTests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloodBankTests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered")] BloodBankTest bloodBankTest)
        {
            if (ModelState.IsValid)
            {
                db.BloodBank.Add(bloodBankTest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloodBankTest);
        }

        // GET: BloodBankTests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodBankTest bloodBankTest = db.BloodBank.Find(id);
            if (bloodBankTest == null)
            {
                return HttpNotFound();
            }
            return View(bloodBankTest);
        }

        // POST: BloodBankTests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered")] BloodBankTest bloodBankTest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloodBankTest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloodBankTest);
        }

        // GET: BloodBankTests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodBankTest bloodBankTest = db.BloodBank.Find(id);
            if (bloodBankTest == null)
            {
                return HttpNotFound();
            }
            return View(bloodBankTest);
        }

        // POST: BloodBankTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BloodBankTest bloodBankTest = db.BloodBank.Find(id);
            db.BloodBank.Remove(bloodBankTest);
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
