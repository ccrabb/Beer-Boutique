using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ViewModels;

namespace Facades
{
    public interface IBeerFacade
    {
        BeerViewModel Get(int id);
        List<BeerViewModel> GetByBrewery(int id);
        List<BeerViewModel> GetByStyle(int id, int take = 0);
        bool Update(BeerViewModel b);
    }
}
