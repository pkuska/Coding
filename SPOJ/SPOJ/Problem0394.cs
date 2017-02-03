using System;
using System.Linq;
using System.Numerics;

namespace SPOJ
{
    public class Problem0394
    {
        public static void Main()
        {
            string n;
            while ((n = Console.ReadLine()) != "0")
            {
                Console.WriteLine(Combinations(n).ToString());
            }
        }

        private static BigInteger Combinations(string n)
        {
            var t = new long[n.Length];
            t[n.Length - 1] = n.Last() == '0' ? 0 : 1;
            for (var i = n.Length - 2; i >= 0; --i)
            {
                if (n[i] == '0') t[i] = 0;
                else if (n[i] == '1' || n[i] == '2' && n[i + 1] <= '6')
                    t[i] = t[i + 1] + (i + 2 < n.Length ? t[i + 2] : 1);
                else t[i] = t[i + 1];
            }
            return t[0];
        }
    }
}
