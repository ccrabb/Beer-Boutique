﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BeerBoutique.Yeast
{
    public static class Helpers
    {
        public static string GetQueryString(IDictionary<string, string> dictionary) {
            if (dictionary == null || dictionary.Count == 0) {
                throw new ArgumentNullException("dictionary");
            }

            var query = new StringBuilder();
            var first = dictionary.ElementAt(0);

            query.Append(first.Key + "=" + first.Value);

            if (dictionary.Count > 1) {
                for (int i = 1; i < dictionary.Count; i++) {
                    var d = dictionary.ElementAt(i);
                    query.Append("&" + d.Key + "=" + d.Value);
                }
            }

            return query.ToString();
        }
    }
}