using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Search
{
    public static class MissingNumber
    {
        public static string InvokeFunction()
        {
            List<int> listOne = new List<int>() { 1, 2, 3, 4, 6 };
            List<int> listTwo = new List<int>() { 1, 2, 3, 4, 5, 6 };

            

            return Missing(listOne, listTwo);
        }

        public static string Missing(List<int> listOne, List<int> listTwo)
        {
            Dictionary<int, int> a = new Dictionary<int, int>();
            Dictionary<int, int> b = new Dictionary<int, int>();

            foreach (int ar in listOne)
            {
                if (a.ContainsKey(ar))
                {
                    a[ar]++;
                }
                else
                {
                    a.Add(ar, 1);
                }
            }

            foreach (int br in listTwo)
            {
                if (b.ContainsKey(br))
                {
                    b[br]++;
                }
                else
                {
                    b.Add(br, 1);
                }
            }
            List<int> missing = new List<int>();
            foreach (var kvp in b)
            {
                int num = kvp.Key;
                int countB = kvp.Value;
                int countA = a.ContainsKey(num) ? a[num] : 0;

                if (countA < countB)
                {
                    missing.Add(num);
                }
            }

            // Sorting as required (if needed)
            missing.Sort();


            return missing.ToString();
        }
    }
}
