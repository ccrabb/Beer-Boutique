using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Models.ViewModels;

namespace BeerBoutique.ApiControllers
{
    public interface IBreweryApiController
    {
        BreweryViewModel Get(int id);
        void Post([FromBody] string value);
        void Put(int id, [FromBody] string value);
        void Delete(int id);
    }
}