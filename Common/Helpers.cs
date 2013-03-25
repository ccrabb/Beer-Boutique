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

        public static Dictionary<int, string> GetDictionary<T>() where T : struct {
            var val = Enum.GetValues(typeof(T)).Cast<object>().ToDictionary(e => (int)e, e => ((Enum)e).GetDescription());
            return val;
        }

        public static string ToJSON(Dictionary<int, string> dict, string keyName = "id", string valueName = "text") {
            var result = dict.OrderBy(y => y.Value).Select(x => String.Format("{{{2}: {0}, {3}: '{1}'}}", x.Key, x.Value, keyName, valueName));
            return "[" + String.Join(",", result) + "]";
        }
    }
}
