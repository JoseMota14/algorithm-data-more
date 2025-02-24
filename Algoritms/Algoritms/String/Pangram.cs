using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algoritms.String
{
    public class Pangram
    {
        public static string InvokeFunction(string input)
        {
            return Pangrams(input);
        }

        /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

        public static string Pangrams(string s)
        {
            HashSet<char> c = new HashSet<char>();

            foreach (char e in s)
            {
                if (char.IsLetter(e))
                    c.Add(Char.ToUpper(e));
            }

            if (c.Count == 26)
            {
                return "pangram";
            }
            return "not pangram";
        }
    }
}
