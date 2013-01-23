using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace BeerBoutique.Controllers
{
    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.InfoMessage = "Beer Boutique is undergoing maintenance from now until forever.  Thanks for your understanding.";
            ViewBag.Title = "GOMBUI - Cheers";
            //WebSecurity.Login("test", "test", true);
            //WebSecurity.CreateUserAndAccount("test", "test");
            return View();
        }
    }
}
