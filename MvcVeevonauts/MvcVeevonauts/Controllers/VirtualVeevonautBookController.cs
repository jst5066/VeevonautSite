using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//  Example: Store
namespace MvcVeevonauts.Controllers
{
    public class VirtualVeevonautBookController : Controller
    {
        //
        // GET: /VirtualVeevonautList/

        public string Index()
        {
            return "Virtual Veevonaut Book: List Coming Soon!";
        }

        public string Browse(string type)
        {
            string message = HttpUtility.HtmlEncode(
                "Virtual Veevonaut Book Browse, Type = " + type);

            return message;
        }

        public string Details()
        {
            return "Virtual Veevonaut Book: Details Coming Soon!";
        }

    }
}
