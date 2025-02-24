using System.Text.RegularExpressions;

namespace Algoritms.String
{
    public static class CamelCase
    {

        public static string InvokeFunction(string input)
        {
            return ($"Work {input} contains {Camelcase(input)} words"); 
        }

        /*
        * Complete the 'camelcase' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts STRING s as parameter.
        */
        public static int Camelcase(string s)
        {
            Regex x = new ("[A-Z]");

            int xx = x.Matches(s).Count;

            return xx + 1;
        }
    }
}
