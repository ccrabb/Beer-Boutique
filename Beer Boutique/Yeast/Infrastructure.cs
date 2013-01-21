using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dispatcher;

namespace BeerBoutique.Yeast
{
    public class GlobalVars {
        private static GlobalVars _globalVars;
        private static int _numOfReferences;

        private GlobalVars() {
            _numOfReferences = 0;
        }

        public static GlobalVars GetInstance() {
            if (_globalVars == null) {
                _globalVars = new GlobalVars();
            }

            _numOfReferences++;

            return _globalVars;
        }
    }

    public class Infrastructure {
        public Infrastructure() {
            var test = GlobalVars.GetInstance();
        }
    }
}