using System;

namespace SPOJ
{
    public class Problem011
    {
        public static void Main()
        {
            var t = int.Parse(Console.ReadLine());
            for (var i = 0; i < t; ++i)
            {
                var n = int.Parse(Console.ReadLine());
                int zn;
                for (zn = 0; n > 0; n /= 5)
                    zn += n / 5;
                Console.WriteLine(zn.ToString());
            }
        }
    }
}
