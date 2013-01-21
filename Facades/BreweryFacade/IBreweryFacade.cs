using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ViewModels;

namespace Facades.BreweryFacade
{
    public interface IBreweryFacade {
        BreweryViewModel Get(int id);
        bool Update(BreweryViewModel brewery);
    }
}
