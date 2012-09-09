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
    public class VeevonautItemsController : Controller
    {
        private VeevonautsDBContext db = new VeevonautsDBContext();

        //
        // GET: /VeevonautItems/

        public ViewResult Index()
        {
            var veevonautitems = db.VeevonautItems.Include(i => i.Type);
            return View(veevonautitems.ToList());
        }

        //
        // GET: /VeevonautItems/Details/5

        public ViewResult Details(int id)
        {
            Item item = db.VeevonautItems.Find(id);
            return View(item);
        }

        //
        // GET: /VeevonautItems/Create

        public ActionResult Create()
        {
            ViewBag.ItemTypeID = new SelectList(db.VeevonautItemTypes, "ItemTypeID", "Name");
            return View();
        } 

        //
        // POST: /VeevonautItems/Create

        [HttpPost]
        public ActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                db.VeevonautItems.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ItemTypeID = new SelectList(db.VeevonautItemTypes, "ItemTypeID", "Name", item.ItemTypeID);
            return View(item);
        }
        
        //
        // GET: /VeevonautItems/Edit/5
 
        public ActionResult Edit(int id)
        {
            Item item = db.VeevonautItems.Find(id);
            ViewBag.ItemTypeID = new SelectList(db.VeevonautItemTypes, "ItemTypeID", "Name", item.ItemTypeID);
            return View(item);
        }

        //
        // POST: /VeevonautItems/Edit/5

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ItemTypeID = new SelectList(db.VeevonautItemTypes, "ItemTypeID", "Name", item.ItemTypeID);
            return View(item);
        }

        //
        // GET: /VeevonautItems/Delete/5
 
        public ActionResult Delete(int id)
        {
            Item item = db.VeevonautItems.Find(id);
            return View(item);
        }

        //
        // POST: /VeevonautItems/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Item item = db.VeevonautItems.Find(id);
            db.VeevonautItems.Remove(item);
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