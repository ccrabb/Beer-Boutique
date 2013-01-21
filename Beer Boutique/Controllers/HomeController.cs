using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerBoutique.Controllers
{
    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.InfoMessage = "Beer Boutique is undergoing maintenance from now until forever.  Thanks for your understanding.";
            return View();
        }
    }
}
