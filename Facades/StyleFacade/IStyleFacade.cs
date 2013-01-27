using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Facades.StyleFacade
{
    public interface IStyleFacade {
        IEnumerable<Category> GetAll();
    }
}
