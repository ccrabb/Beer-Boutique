using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Models.ViewModels;
using Yeast.Constants;

namespace Facades.BeerFacade
{
    public class BeerFacade : BaseFacade, IBeerFacade
    {
        public BeerFacade()
        {
            
        }
        public BeerViewModel Get(int id)
        {
            using (var context = new BeerBoutiqueEntities())
            {
                var beer = (from x in context.Beers
                            where x.ID == id
                            select x).FirstOrDefault();


                if (beer != null) {
                    var b = new BeerViewModel(beer);
                    b.SimilarBeers = GetByStyle(beer.StyleID, 3);
                    return b;
                }
                else throw new Exception("Not Found");
            }
        }

        public bool Update(BeerViewModel b) {
            using (var context = new BeerBoutiqueEntities()) {

                var oldBeer = (from x in context.Beers
                               where x.ID == b.ID
                               select x).FirstOrDefault();

                if (oldBeer == null) {
                    return false;
                }

                oldBeer.IBU = b.IBU;
                oldBeer.ABV = b.ABV;
                oldBeer.Description = b.Description;
                oldBeer.Name = b.Name;
                oldBeer.SRM = b.SRM;
                context.SaveChanges();
                return true;
            }
        }

        public List<BeerViewModel> Top(BeerStyle? style) {
            using (var context = new BeerBoutiqueEntities()) {
                var t = context.Ratings.GroupBy(x => x.Beer).Select(y => new
                {
                    BeerID = y.Key.ID,
                    AverageOverall = y.Average(z => z.Overall)
                }).OrderBy(x => x.AverageOverall).Take(10);

                var b = new List<BeerViewModel>();
                foreach (var a in t) {
                    b.Add(new BeerViewModel(context.Beers.SingleOrDefault(x => x.ID == a.BeerID)));
                }

                //var beers = context.Beers.Join(t, Beers => Beers.ID, Ratings => Ratings.BeerID, (beer, rating) => new BeerViewModel(beer)).ToList();

                return b.OrderByDescending(x => x.AverageOverall).ToList();
            }
        }

        public List<BeerViewModel> GetByBrewery(int id)
        {
            using (var context = new BeerBoutiqueEntities())
            {
                var beers = (from x in context.Beers
                             where x.BreweryID == id
                             select x).ToList();

                return beers.Select(x => new BeerViewModel(x)).ToList();
            }
        }

        public List<BeerViewModel> GetByStyle(int id, int take = 0)
        {
            using (var context = new BeerBoutiqueEntities())
            {
                var beers = (from x in context.Beers
                             where x.StyleID == id
                             select x).ToList();

                var ret = beers.Select(x => new BeerViewModel(x)).ToList();

                if (take == 0)
                    return ret;
                
                return ret.Take(take).ToList();
            }
        }
    }
}
