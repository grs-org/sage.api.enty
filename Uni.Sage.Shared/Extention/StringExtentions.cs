using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Uni.Sage.Shared.Extention
{
    public static class StringExtentions
    {
        public static void AddLigne(this string str, string ligne)
        {
            if (string.IsNullOrEmpty(str))
            {
                str = ligne;
            }
            else
            {
                str += Environment.NewLine + ligne;
            }
        }

        public static string Increment(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return "1";

            // Utilisation d'une regex pour trouver le nombre à la fin de la chaîne
            var match = Regex.Match(str, @"(\d+)$");

            if (!match.Success) return str + "1";

            // Obtenir la partie du nombre et l'incrémenter
            string numberStr = match.Value;
            int number = int.Parse(numberStr) + 1;

            // Remplacer l'ancien nombre par le nouveau nombre avec le format requis
            string incrementedStr = str.Replace(numberStr, number.ToString().PadLeft(numberStr.Length, '0'));

            return incrementedStr;


            //if (string.IsNullOrWhiteSpace(str)) return "1";
            //var match =System.Text.RegularExpressions.Regex.Match(str, @"(\d+)(?!.*\d)");
            //if (match == null) return str + "1";
            //return str.Replace(match.Value, (int.Parse(match.Value) +1).ToString());
           // var newString = System.Text.RegularExpressions.Regex.Replace(str, "\\d+", m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));           
           // return newString;
        }

    }
}
