using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace SPOJ
{
    public class Problem0006
    {
        public static void Main()
        {
            for (var t = int.Parse(Console.ReadLine()); t > 0; --t)
            {
                var term = Regex.Split(Console.ReadLine(), "(-|\\+|\\*)");
                var a = BigInteger.Parse(term[0]);
                var b = BigInteger.Parse(term[2]);
                var r = term[1] == "-" ? a - b : term[1] == "+" ? a + b : a * b;
                var rs = r.ToString();
                string d = null;
                var spaces = Math.Max(term[0].Length, Math.Max(rs.Length, term[2].Length + 1));
                var partial = new List<string>();

                if (term[1] == "*" && term[2].Length > 1)
                {
                    var offset = 0;
                    var dashes = 0;
                    foreach (var prs in term[2].Reverse().Select(c => (a * (c - 48)).ToString() + new string(' ', offset++)))
                    {
                        if (d == null)
                            d = new string('-', Math.Max(prs.Length, term[2].Length + 1));
                        partial.Add(prs);
                        spaces = Math.Max(spaces, prs.Length);
                        dashes = Math.Max(dashes, prs.Length);
                    }
                    partial.Add(new string('-', Math.Max(rs.Length, dashes)));
                }

                if (d == null) d = new string('-', Math.Max(rs.Length, term[2].Length + 1));

                if (term[0].Length < spaces) Console.Write(new string(' ', spaces - term[0].Length));
                Console.WriteLine(term[0]);
                if (term[2].Length < spaces - 1) Console.Write(new string(' ', spaces - term[2].Length - 1));
                Console.Write(term[1]);
                Console.WriteLine(term[2]);
                if (d.Length < spaces) Console.Write(new string(' ', spaces - d.Length));
                Console.WriteLine(d);

                foreach (var p in partial)
                {
                    if (p.Length < spaces) Console.Write(new string(' ', spaces - p.Length));
                    Console.WriteLine(p);
                }

                if (rs.Length < spaces) Console.Write(new string(' ', spaces - rs.Length));
                Console.WriteLine(rs);
                Console.WriteLine();
            }
        }
    }
}
