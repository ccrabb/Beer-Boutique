using System.Linq;
using Models;
using Models.ViewModels;

namespace Facades.BreweryFacade
{
    public class BreweryFacade : BaseFacade, IBreweryFacade
    {
        public BreweryViewModel Get(int id) {

            using (var context = new BeerBoutiqueEntities()) {
                var brewery = (from x in context.Breweries
                               where x.ID == id
                               select x).FirstOrDefault();

                return new BreweryViewModel(brewery);
            }
        }

        public bool Update(BreweryViewModel b) {

            using (var context = new BeerBoutiqueEntities())
            {
                var brewery = (from x in context.Breweries
                               where x.ID == b.ID
                               select x).FirstOrDefault();

                if (brewery == null)
                    return false;
                
                context.SaveChanges();
                return true;
            }
        }
    }
}
