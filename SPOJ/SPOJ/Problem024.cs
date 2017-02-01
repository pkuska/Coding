using System;
using System.Numerics;

namespace SPOJ
{
    public class Problem024
    {
        public static void Main()
        {
            for (var t = int.Parse(Console.ReadLine()); t > 0; --t)
                Console.WriteLine(Factorial(int.Parse(Console.ReadLine())).ToString());
        }

        private static BigInteger Factorial(int n)
        {
            if (n == 0) return 1;
            return Factorial(n - 1) * n;
        }
    }
}
