using System;
using System.Collections;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SPOJ.Tests
{
    public class ConsoleRedirectFixture
    {
        private readonly Action _testAction;
        public const string Separator = " ";

        public ConsoleRedirectFixture(Action testAction)
        {
            _testAction = testAction;
        }

        protected void InputOutputTest<T1, T2>(T1 input, T2 expectedOutput)
            =>
                InputOutputTest(Stringify(input), Stringify(expectedOutput));

        private static string Stringify<T>(T value, bool topLevel = true)
        {
            if (value is IEnumerable)
                return string.Join(topLevel ? Environment.NewLine : Separator,
                    (value as IEnumerable).Cast<object>().Select(x => Stringify(x, false)));
            return value.ToString();
        }

        protected void InputOutputTest(string input, string expectedOutput)
        {
            using (var reader = new StringReader(input))
            using (var writer = new StringWriter())
            {
                Console.SetIn(reader);
                Console.SetOut(writer);
                _testAction();
                Assert.That(writer.ToString().Trim(), Is.EqualTo(expectedOutput.Trim()));
            }
        }
    }
}
