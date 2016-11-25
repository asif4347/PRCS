﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRCS.Models;

namespace PRCS1.Controllers
{
    public class BloodDonorInfoesController : Controller
    {
        private BloodDbContext db = new BloodDbContext();

        // GET: BloodDonorInfoes
        public ActionResult Index(string sName,string bloodGroup,string donorNo)
        {

            var bloodLst = new List<string>();
            var bloodQry = from d in db.BloodInfo
                           orderby d.BloodGroup
                           select d.BloodGroup;
            bloodLst.AddRange(bloodQry.Distinct());
            ViewBag.bloodGroup = new SelectList(bloodLst);


            

            var blood = from m in db.BloodInfo
                        select m;

            if (!String.IsNullOrEmpty(sName))
            {
                blood = blood.Where(s => s.Name.Contains(sName));
            }
            if (!string.IsNullOrEmpty(bloodGroup))
            {
                blood = blood.Where(x => x.BloodGroup == bloodGroup);
            }
            if (!String.IsNullOrEmpty(donorNo))
            {
                blood = blood.Where(r => r.DonorNo == donorNo);
            }



            return View(blood);



        }

        // GET: BloodDonorInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodDonorInfo bloodDonorInfo = db.BloodInfo.Find(id);
            if (bloodDonorInfo == null)
            {
                return HttpNotFound();
            }
            return View(bloodDonorInfo);
        }

        // GET: BloodDonorInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloodDonorInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DonorNo,SerialNo,Name,SonOf,Gender,DOB,Weight,BloodGroup,LastDonation,NoOfDonation,Adress,District,PermanentDonor,TTIScreening,Institute,Class,TelResidance,TelOffice,FAX,Mobile,Email")] BloodDonorInfo bloodDonorInfo)
        {
            if (ModelState.IsValid)
            {
                bloodDonorInfo.Sr += 1;
                db.BloodInfo.Add(bloodDonorInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(bloodDonorInfo);
        }

        // GET: BloodDonorInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodDonorInfo bloodDonorInfo = db.BloodInfo.Find(id);
            if (bloodDonorInfo == null)
            {
                return HttpNotFound();
            }
            return View(bloodDonorInfo);
        }

        // POST: BloodDonorInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DonorNo,SerialNo,Name,SonOf,Gender,DOB,Weight,BloodGroup,LastDonation,NoOfDonation,Adress,District,PermanentDonor,TTIScreening,Institute,Class,TelResidance,TelOffice,FAX,Mobile,Email")] BloodDonorInfo bloodDonorInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloodDonorInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloodDonorInfo);
        }

        // GET: BloodDonorInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodDonorInfo bloodDonorInfo = db.BloodInfo.Find(id);
            if (bloodDonorInfo == null)
            {
                return HttpNotFound();
            }
            return View(bloodDonorInfo);
        }

        // POST: BloodDonorInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BloodDonorInfo bloodDonorInfo = db.BloodInfo.Find(id);
            db.BloodInfo.Remove(bloodDonorInfo);
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
