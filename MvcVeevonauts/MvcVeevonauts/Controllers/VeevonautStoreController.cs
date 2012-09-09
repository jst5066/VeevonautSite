using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcVeevonauts.Models;

//  Example: Store
namespace MvcVeevonauts.Controllers
{
    public class VeevonautStoreController : Controller
    {
        VeevonautsDBContext db = new VeevonautsDBContext();

        //
        // GET: /VirtualVeevonautList/

        public ActionResult Index()
        {
            var itemTypes = db.VeevonautItemTypes.ToList();

            return View(itemTypes);
        }

        public ActionResult Browse(string itemType)
        {
            var itemTypeModel = db.VeevonautItemTypes.Include("Items")
                .Single(g => g.Name == itemType);

            return View(itemTypeModel);
        }

        public ActionResult Details(int id)
        {
            var Item = new Item { SubType = "Item " + id };

            return View(Item);
        }

    }
}
