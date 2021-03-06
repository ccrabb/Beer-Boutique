﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Facades.BeerFacade;
using Facades.StyleFacade;
using Models.ViewModels;
using Yeast.Constants;
using Models;

namespace BeerBoutique.Controllers
{
    public class BeerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.InfoMessage = "GOMBUI is undergoing maintenance from now until forever.  Thanks for your understanding.";
            var apiController = new ApiControllers.BeerController(new BeerFacade());
            var beer = apiController.Get(id);

            ViewBag.Title = beer.Name + " - GOMBUI";
            return View(beer);
        }
        // GET: /Beer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Beer/Create

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
        // GET: /Beer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Beer/Edit/5

        [HttpPost]
        [Authorize(Roles = "Geek")]
        public ActionResult Edit(BeerViewModel beer)
        {
            if (ModelState.IsValid)
            {
                var beerFacade = new BeerFacade();
                beerFacade.Update(beer);

                return View();
            }
            else
            {
                throw new Exception("Invalid Model State");
            }
        }

        public JsonResult GetByBrewery(int id, int take = 0, int skip = 0)
        {
            int echo = 0;
            if (Request["sEcho"] != null)
            {
                if (!Int32.TryParse(Request["sEcho"], out echo))
                {
                    throw new HttpRequestException("XSS Attack possibly attempted");
                }
            }

            var beerController = new ApiControllers.BeerController(new BeerFacade());
            var beers = beerController.ByBrewery(id, take, skip);
            return Json(new
            {
                iTotalRecords = beers.Count(),
                iTotalDisplayRecords = beers.Count(),
                sEcho = echo,
                aaData = beers.Select(x => new[]
                        {
                            x.Name,
                            x.Style,
                            x.ABV.ToString(),
                            x.AverageOverall.ToString(),
                            x.ID.ToString()
                        })

            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTop(BeerStyle? style = null)
        {
            int echo = 0;
            if (Request["sEcho"] != null)
            {
                if (!Int32.TryParse(Request["sEcho"], out echo))
                {
                    throw new HttpRequestException("XSS Attack possibly attempted");
                }
            }

            var beerFacade = new BeerFacade();
            var res = beerFacade.Top(style);

            return Json(new
            {
                iTotalRecords = res.Count(),
                iTotalDisplayRecords = res.Count(),
                sEcho = echo,
                aaData = res.Select(x => new[]
                        {
                            x.Name,
                            x.Style,
                            x.ABV.ToString(),
                            x.AverageOverall.ToString(),
                            x.ID.ToString()
                        })

            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Style(int styleId)
        {
            var styleFacade = new StyleFacade();

            return View(styleFacade.Get(styleId));
        }

        public JsonResult GetByStyle(int id)
        {
            var echo = 0;
            var take = 0;
            var skip = 0;

            if (Request["sEcho"] != null)
            {
                if (!Int32.TryParse(Request["sEcho"], out echo))
                {
                    throw new HttpRequestException("XSS Attack possibly attempted");
                }
            }

            if (Request["iDisplayStart"] != null)
            {
                if (!Int32.TryParse(Request["iDisplayStart"], out skip))
                {
                    skip = 0;
                }
            }

            if (Request["iDisplayLength"] != null)
            {
                if (!Int32.TryParse(Request["iDisplayLength"], out take))
                {
                    take = 50;
                }
            }

            var beerFacade = new BeerFacade();
            var beers = beerFacade.GetByStyle(id);
            return Json(new
            {
                iTotalRecords = beers.Count(),
                iTotalDisplayRecords = beers.Count(),
                sEcho = echo,
                aaData = beers.Skip(skip).Take(take).Select(x => new[]
                        {
                            x.Name,
                            x.Style,
                            x.ABV.ToString(),
                            x.AverageOverall.ToString(),
                            x.ID.ToString()
                        })

            }, JsonRequestBehavior.AllowGet);
        }
    }
}
