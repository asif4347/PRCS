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
    public class LibTestBloodsController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: LibTestBloods
        public ActionResult Index()
        {
            return View(db.LibTest.ToList());
        }

        // GET: LibTestBloods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibTestBlood libTestBlood = db.LibTest.Find(id);
            if (libTestBlood == null)
            {
                return HttpNotFound();
            }
            return View(libTestBlood);
        }

        // GET: LibTestBloods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibTestBloods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered")] LibTestBlood libTestBlood)
        {
            if (ModelState.IsValid)
            {
                db.LibTest.Add(libTestBlood);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(libTestBlood);
        }

        // GET: LibTestBloods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibTestBlood libTestBlood = db.LibTest.Find(id);
            if (libTestBlood == null)
            {
                return HttpNotFound();
            }
            return View(libTestBlood);
        }

        // POST: LibTestBloods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Contact,Result,isDelivered")] LibTestBlood libTestBlood)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libTestBlood).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(libTestBlood);
        }

        // GET: LibTestBloods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibTestBlood libTestBlood = db.LibTest.Find(id);
            if (libTestBlood == null)
            {
                return HttpNotFound();
            }
            return View(libTestBlood);
        }

        // POST: LibTestBloods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LibTestBlood libTestBlood = db.LibTest.Find(id);
            db.LibTest.Remove(libTestBlood);
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
