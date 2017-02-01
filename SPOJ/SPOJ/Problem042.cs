using System;
using System.Linq;

namespace SPOJ
{
    public class Problem042
    {
        public static void Main()
        {
            for (var n = int.Parse(Console.ReadLine()); n > 0; --n)
            {
                var inputLine = Console.ReadLine().Split(' ').Select(x => new string(x.Reverse().ToArray())).Select(int.Parse).ToArray();
                var a = inputLine[0];
                var b = inputLine[1];
                Console.WriteLine(int.Parse(new string((a + b).ToString().Reverse().ToArray())));
            }
        }
    }
}
