using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Constants;
using Facades;
using Facades.BeerFacade;
using Models.ViewModels;

namespace BeerBoutique.ApiControllers
{
    public class BeerController : ApiController, IBeerApiController {
        private readonly IBeerFacade _beerFacade;

        public BeerController(IBeerFacade facade) {
            _beerFacade = facade;
        }

        // GET api/beer
        [HttpGet]
        public IEnumerable<BeerViewModel> Get() {
            var beers = _beerFacade.GetByStyle(10);

            if(beers == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return beers;
        }

        // GET api/beer/5
        [HttpGet]
        public BeerViewModel Get(int id) {
            var beer = _beerFacade.Get(id);

            if(beer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return beer;
        }

        [HttpGet]
        public IEnumerable<BeerViewModel> ByStyle(Style style) {
            var beers = _beerFacade.GetByStyle((int)style);

            return beers;
        }

        [HttpGet]
        public IEnumerable<BeerViewModel> ByBrewery(int id, int take = 0, int skip = 0)
        {
            var beers = _beerFacade.GetByBrewery(id);

            return beers;
        } 

        // POST api/beer
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/beer/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/beer/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
