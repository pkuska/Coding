using System;
using System.Collections.Generic;

namespace SPOJ
{
    public class Problem346
    {
        private static readonly Dictionary<long, long> Mem = new Dictionary<long, long>();
        public static void Main()
        {
            int n;
            while (int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine(Split(n).ToString());
        }

        private static long Split(int n)
        {
            if (n == 0) return 0;
            if (!Mem.ContainsKey(n)) Mem[n] = Math.Max(n, Split(n / 2) + Split(n / 3) + Split(n / 4));
            return Mem[n];
        }
    }
}
