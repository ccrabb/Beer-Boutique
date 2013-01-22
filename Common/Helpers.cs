using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeast
{
    public static class Helpers
    {
        public static string GetDescription(this Enum e) {
            var fieldInfo = e.GetType().GetField(e.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof (DescriptionAttribute), false);

            if (attributes.Length > 0) {
                return ((DescriptionAttribute) attributes[0]).Description;
            }
            
            return e.ToString();
        }
    }
}
