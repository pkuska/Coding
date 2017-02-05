using System;

namespace SPOJ
{
    public class Problem0005
    {
        public static void Main()
        {
            for (var t = int.Parse(Console.ReadLine()); t > 0; --t)
            {
                var str = Console.ReadLine();
                var n = str.Length;
                var r = str.ToCharArray();

                var cf = true;
                for (var i = n - 1; i >= n / 2; --i)
                {
                    if (str[i] == str[n - 1 - i]) continue;
                    r[i] = str[n - 1 - i];
                    cf = str[i] >= str[n - 1 - i];
                }

                for (var i = (n - 1) / 2; i >= 0 && cf; --i)
                {
                    if (r[i] == '9')
                    {
                        r[i] = '0';
                    }
                    else
                    {
                        r[i]++;
                        cf = false;
                    }
                    r[n - 1 - i] = r[i];
                }

                if (cf)
                {
                    Console.Write('1');
                    r[n - 1] = '1';
                }
                Console.WriteLine(new string(r));
            }
        }
    }
}
