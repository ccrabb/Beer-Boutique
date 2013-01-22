using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Yeast.Constants;
using Models.ViewModels;

namespace BeerBoutique.ApiControllers
{
    public interface IBeerApiController
    {
        IEnumerable<BeerViewModel> Get();
        BeerViewModel Get(int id);
        IEnumerable<BeerViewModel> ByStyle(Style style);
        IEnumerable<BeerViewModel> ByBrewery(int id, int take = 0, int skip = 0);
        void Post([FromBody] string value);
        void Put(int id, [FromBody] string value);
        void Delete(int id);
    }
}