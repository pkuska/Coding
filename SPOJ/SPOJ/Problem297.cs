using System;
using System.Collections.Generic;
using System.Linq;

namespace SPOJ
{
    public class Problem297
    {
        public static void Main()
        {
            for (var t = int.Parse(Console.ReadLine()); t > 0; --t)
            {
                var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var n = inputLine[0];
                var c = inputLine[1];
                var stalls = new List<int>();
                for (var j = 0; j < n; ++j)
                    stalls.Add(int.Parse(Console.ReadLine()));
                stalls.Sort();
                int b = 0, max = 0, e = stalls.Last() - stalls.First();
                while (b < e)
                {
                    var mid = (e + b) / 2;
                    if (PlaceCows(c, mid, stalls))
                    {
                        max = Math.Max(max, mid);
                        b = mid + 1;
                    }
                    else
                        e = mid;
                }
                Console.WriteLine(max.ToString());
            }
        }

        private static bool PlaceCows(int c, int s, IReadOnlyList<int> stalls)
        {
            int p = stalls[0], cows = 1;
            for (var i = 1; i < stalls.Count; i++)
            {
                if (stalls[i] - p < s) continue;
                p = stalls[i];
                cows++;
                if (cows == c) return true;
            }
            return false;
        }
    }
}
