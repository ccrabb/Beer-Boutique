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

                brewery.Description = b.Description;
                brewery.Name = b.Name;
                brewery.Contact.Address.Locality = b.Locality;
                brewery.Contact.Address.Region = b.Region;
                brewery.Contact.Phone = b.Phone;
                brewery.Contact.Website = b.Uri;
                context.SaveChanges();
                return true;
            }
        }
    }
}
