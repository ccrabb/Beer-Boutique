using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Models;

namespace Facades.SearchFacade
{
    public interface ISearchFacade {
        IEnumerable<SearchAllAzure_Result> Search(string query, string userID, int limit);
    }
}
