using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Facades;
using Facades.BreweryFacade;
using Models;
using Models.ViewModels;

namespace BeerBoutique.ApiControllers
{
    public class BreweryController : ApiController, IBreweryApiController {

        private readonly IBreweryFacade _breweryFacade;

        public BreweryController(IBreweryFacade breweryFacade) {
            _breweryFacade = breweryFacade;
        }

        // GET api/brewery
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/brewery/5
        public BreweryViewModel Get(int id)
        {
            var brewery = _breweryFacade.Get(id);

            if (brewery == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return brewery;
        }

        // POST api/brewery
        public void Post([FromBody]string value)
        {
        }

        // PUT api/brewery/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/brewery/5
        public void Delete(int id)
        {
        }
    }
}
