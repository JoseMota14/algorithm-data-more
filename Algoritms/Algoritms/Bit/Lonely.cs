using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Bit
{
    public static class Lonely
    {
        public static string InvokeFunction(string input)
        {
            return Lone(input);
        }

        private static string Lone(string input)
        {
            Dictionary<int, int> freq= new Dictionary<int, int>();

            foreach(char c in input)
            {
                int num = c - '0';
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            var x = freq.Where(x => x.Value == 1).First().Key;

            return x.ToString();
        }
    }
}
