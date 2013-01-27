using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Facades.StyleFacade
{
    public class StyleFacade : IStyleFacade
    {
        public IEnumerable<Category> GetAll() {
            using (var context = new BeerBoutiqueEntities()) {
                return context.Categories.Include("Styles").ToList();
            }
        } 

        public Style Get(int id) {
            using (var context = new BeerBoutiqueEntities()) {
                return context.Styles.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
