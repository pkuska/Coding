using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SPOJ
{
    public class Problem6256
    {
        private const int MaxN = 1000000000;
        public static void Main()
        {
            var t = int.Parse(Console.ReadLine());
            var ba = new BitArray((int)Math.Sqrt(MaxN) + 1, true);
            var sqrtN = (int)Math.Sqrt(MaxN);
            ba[1] = ba[0] = false;

            for (var i = 2; i * i <= sqrtN; ++i)
                if (ba[i])
                    for (var j = i * i; j <= sqrtN; j += i)
                        ba[j] = false;

            var ps = new List<int>();

            for (var i = 2; i <= sqrtN; ++i)
                if (ba[i]) ps.Add(i);

            for (var i = 0; i < t; ++i)
            {
                var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var n = inputLine[0];
                var m = inputLine[1];
                var qs = ps.Select(p => (p - n % p) % p).ToList();
                var rba = new BitArray(m - n + 1, true);
                for (var j = n; j <= sqrtN && j <= m; ++j)
                    rba[j - n] = ba[j];
                for (var j = 0; j < qs.Count; ++j)
                    for (var k = qs[j]; k <= m - n; k += ps[j])
                        rba[k] = k + n <= sqrtN && ba[k + n];
                for (var j = 0; j <= m - n; ++j)
                    if (rba[j]) Console.WriteLine((j + n).ToString());
                Console.WriteLine();
            }
        }
    }
}
