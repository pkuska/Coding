using System;
using System.Collections.Generic;

namespace SPOJ
{
    public class Problem6256
    {
        public static void Main()
        {
            for (var t = int.Parse(Console.ReadLine()); t > 0; --t)
            {
                Console.ReadLine();
                var n = int.Parse(Console.ReadLine());
                var a = new int[n];
                for (var i = 0; i < n; ++i) a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(Inversions(a, 0, n - 1));
            }
        }

        private static long Inversions(IList<int> p, int b, int e)
        {
            if (b >= e) return 0;
            return Inversions(p, b, (b + e) / 2) + Inversions(p, (b + e) / 2 + 1, e) + Merge(p, b, e);
        }

        private static long Merge(IList<int> p, int b, int e)
        {
            long r = 0;
            var t = new int[e - b + 1];
            var inv = 0;
            for (int i = b, j = (b + e) / 2 + 1; i <= (b + e) / 2 || j <= e;)
            {
                var c = i - b + j - (b + e) / 2 - 1;
                if (i > (b + e) / 2) t[c] = p[j++];
                else if (j > e)
                {
                    t[c] = p[i++];
                    r += inv;
                }
                else if (p[i] > p[j])
                {
                    t[c] = p[j++];
                    inv++;
                }
                else
                {
                    t[c] = p[i++];
                    r += inv;
                }
            }

            for (var i = b; i <= e; ++i) p[i] = t[i - b];

            return r;
        }
    }
}
