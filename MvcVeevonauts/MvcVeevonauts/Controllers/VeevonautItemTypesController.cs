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
    public class VeevonautItemTypesController : Controller
    {
        private VeevonautsDBContext db = new VeevonautsDBContext();

        //
        // GET: /VeevonautItemTypes/

        public ViewResult Index()
        {
            return View(db.VeevonautItemTypes.ToList());
        }

        //
        // GET: /VeevonautItemTypes/Details/5

        public ViewResult Details(int id)
        {
            ItemType itemtype = db.VeevonautItemTypes.Find(id);
            return View(itemtype);
        }

        //
        // GET: /VeevonautItemTypes/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /VeevonautItemTypes/Create

        [HttpPost]
        public ActionResult Create(ItemType itemtype)
        {
            if (ModelState.IsValid)
            {
                db.VeevonautItemTypes.Add(itemtype);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(itemtype);
        }
        
        //
        // GET: /VeevonautItemTypes/Edit/5
 
        public ActionResult Edit(int id)
        {
            ItemType itemtype = db.VeevonautItemTypes.Find(id);
            return View(itemtype);
        }

        //
        // POST: /VeevonautItemTypes/Edit/5

        [HttpPost]
        public ActionResult Edit(ItemType itemtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemtype);
        }

        //
        // GET: /VeevonautItemTypes/Delete/5
 
        public ActionResult Delete(int id)
        {
            ItemType itemtype = db.VeevonautItemTypes.Find(id);
            return View(itemtype);
        }

        //
        // POST: /VeevonautItemTypes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ItemType itemtype = db.VeevonautItemTypes.Find(id);
            db.VeevonautItemTypes.Remove(itemtype);
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