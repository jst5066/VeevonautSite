using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcVeevonauts.Models;

namespace MvcVeevonauts.Controllers
{ 
    public class VirtualVeevonautsController : Controller
    {
        private VeevonautsDBContext db = new VeevonautsDBContext();

        //
        // GET: /VirtualVeevonauts/

        public ViewResult Index()
        {
            return View(db.VirtualVeevonauts.ToList());
        }

        //
        // GET: /VirtualVeevonauts/Details/5

        public ViewResult Details(int id)
        {
            VirtualVeevonaut virtualveevonaut = db.VirtualVeevonauts.Find(id);
            return View(virtualveevonaut);
        }

        //
        // GET: /VirtualVeevonauts/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /VirtualVeevonauts/Create

        [HttpPost]
        public ActionResult Create(VirtualVeevonaut virtualveevonaut)
        {
            if (ModelState.IsValid)
            {
                db.VirtualVeevonauts.Add(virtualveevonaut);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(virtualveevonaut);
        }
        
        //
        // GET: /VirtualVeevonauts/Edit/5
 
        public ActionResult Edit(int id)
        {
            VirtualVeevonaut virtualveevonaut = db.VirtualVeevonauts.Find(id);
            return View(virtualveevonaut);
        }

        //
        // POST: /VirtualVeevonauts/Edit/5

        [HttpPost]
        public ActionResult Edit(VirtualVeevonaut virtualveevonaut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(virtualveevonaut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(virtualveevonaut);
        }

        //
        // GET: /VirtualVeevonauts/Delete/5
 
        public ActionResult Delete(int id)
        {
            VirtualVeevonaut virtualveevonaut = db.VirtualVeevonauts.Find(id);
            return View(virtualveevonaut);
        }

        //
        // POST: /VirtualVeevonauts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            VirtualVeevonaut virtualveevonaut = db.VirtualVeevonauts.Find(id);
            db.VirtualVeevonauts.Remove(virtualveevonaut);
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