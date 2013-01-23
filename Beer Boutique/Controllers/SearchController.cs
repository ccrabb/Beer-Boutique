using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facades.SearchFacade;
using Models.Models;

namespace BeerBoutique.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public JsonResult Index(string q, int limit) {
            if (String.IsNullOrWhiteSpace(q)) {
                throw new ArgumentNullException("q");
            }

            var searchController = new SearchFacade();
            var results = searchController.Search(q, null, limit).Select(x => new
            {
                ID = x.ID,
                Name = x.Name,
                SearchType = ((SearchType)x.SearchType).ToString(),
                Description = x.Description
            });
            return Json(results, JsonRequestBehavior.AllowGet);
        }

    }
}
