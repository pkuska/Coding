using System;
using System.Collections.Generic;
using System.Linq;

namespace SPOJ
{
    public class Problem004
    {
        private const char OpeningBracket = '(';
        private const char ClosingBracket = ')';
        private static readonly char[] Precedence = new[] { OpeningBracket, '^', '/', '*', '-', '+' };
        private static readonly Stack<char> Ops = new Stack<char>();
        public static void Main()
        {
            for (var t = int.Parse(Console.ReadLine()); t > 0; --t)
                Console.WriteLine(new string(Rpn(Console.ReadLine()).ToArray()));
        }

        private static IEnumerable<char> Rpn(string expression)
        {
            foreach (var c in expression)
            {
                if (!IsOperator(c) && !IsBracket(c)) yield return c;
                else if (IsOpeningBracket(c)) Ops.Push(c);
                else if (IsClosingBracket(c)) for (var pc = Ops.Pop(); !IsOpeningBracket(pc); pc = Ops.Pop()) yield return pc;
                else if (Ops.Count == 0 || !Precedes(c, Ops.Peek())) Ops.Push(c);
                else yield return c;
            }
            foreach (var c in Ops) yield return c;
        }

        private static bool IsBracket(char c)
        {
            return IsOpeningBracket(c) || IsClosingBracket(c);
        }

        private static bool IsOperator(char c)
        {
            return Precedence.Contains(c);
        }

        private static bool IsOpeningBracket(char c)
        {
            return c == OpeningBracket;
        }

        private static bool IsClosingBracket(char c)
        {
            return c == ClosingBracket;
        }

        private static bool Precedes(char c, char pc)
        {
            return Array.IndexOf(Precedence, c) < Array.IndexOf(Precedence, pc);
        }
    }
}
