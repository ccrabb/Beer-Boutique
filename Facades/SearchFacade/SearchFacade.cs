using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Models;

namespace Facades.SearchFacade
{
    public class SearchFacade : BaseFacade, ISearchFacade
    {
        public IEnumerable<SearchAll_Result> Search(string query, string userID = null, int limit = 15) {
            using (var context = new BeerBoutiqueEntities()) {
                return context.SearchAll(query, userID).Take(limit).ToList();
            }
        }
    }
}
