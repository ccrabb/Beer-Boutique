using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facades.StyleFacade;
using Models;

namespace BeerBoutique.Controllers
{
    public class StyleController : Controller
    {
        public ActionResult Index() {
            var styleFacade = new StyleFacade();
            var categories = styleFacade.GetAll();

            return View(categories);
        }

        [ChildActionOnly]
        public PartialViewResult _StyleBeerList(Category category) {

            return PartialView(category);
        }

    }
}
