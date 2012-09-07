using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcVeevonauts.Models;
using MvcVeevonauts.VeevonautsDBContext__MvcVeevonauts;

namespace MvcVeevonauts.Controllers
{ 
    public class VeevonautsController : Controller
    {
        private Models_ db = new Models_();

        //
        // GET: /Veevonauts/

        public ViewResult Index()
        {
            return View(db.Veevonauts.ToList());
        }

        //
        // GET: /Veevonauts/Details/5

        public ViewResult Details(int id)
        {
            Veevonaut veevonaut = db.Veevonauts.Find(id);
            return View(veevonaut);
        }

        //
        // GET: /Veevonauts/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Veevonauts/Create

        [HttpPost]
        public ActionResult Create(Veevonaut veevonaut)
        {
            if (ModelState.IsValid)
            {
                db.Veevonauts.Add(veevonaut);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(veevonaut);
        }
        
        //
        // GET: /Veevonauts/Edit/5
 
        public ActionResult Edit(int id)
        {
            Veevonaut veevonaut = db.Veevonauts.Find(id);
            return View(veevonaut);
        }

        //
        // POST: /Veevonauts/Edit/5

        [HttpPost]
        public ActionResult Edit(Veevonaut veevonaut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veevonaut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veevonaut);
        }

        //
        // GET: /Veevonauts/Delete/5
 
        public ActionResult Delete(int id)
        {
            Veevonaut veevonaut = db.Veevonauts.Find(id);
            return View(veevonaut);
        }

        //
        // POST: /Veevonauts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Veevonaut veevonaut = db.Veevonauts.Find(id);
            db.Veevonauts.Remove(veevonaut);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}