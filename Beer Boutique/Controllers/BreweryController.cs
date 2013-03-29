using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facades.BreweryFacade;
using Models.ViewModels;

namespace BeerBoutique.Controllers
{
    public class BreweryController : Controller
    {
        //
        // GET: /Brewery/
        public ActionResult Index() {
            ViewBag.Title = "Breweries - GOMBUI";
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.InfoMessage = "GOMBUI is undergoing maintenance from now until forever.  Thanks for your understanding.";
            var brewController = new ApiControllers.BreweryController(new BreweryFacade());
            var b = brewController.Get(id);

            ViewBag.Title = b.Name + " - GOMBUI";
            return View(b);
        }

        //
        // GET: /Brewery/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Brewery/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Brewery/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Brewery/Edit/5

        [HttpPost]
        [Authorize(Roles="Geek")]
        public ActionResult Edit(BreweryViewModel brewery)
        {
            if (ModelState.IsValid)
            {
                var beerFacade = new BreweryFacade();
                beerFacade.Update(brewery);

                return View();
            }
            else
            {
                throw new Exception("Invalid Model State");
            }
        }
    }
}
