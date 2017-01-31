using System;
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

        protected void InputOutputTest<T1, T2>(T1[] input, T2[] expectedOutput)
            where T1 : struct
            where T2 : struct
            =>
                InputOutputTest(input.Select(x => x.ToString()).ToArray(),
                    expectedOutput.Select(x => x.ToString()).ToArray());

        protected void InputOutputTest<T1, T2>(T1[][] input, T2[][] expectedOutput)
            where T1 : struct
            where T2 : struct
            =>
                InputOutputTest(input.Select(x => x.Select(y => y.ToString()).ToArray()).ToArray(),
                    expectedOutput.Select(x => x.Select(y => y.ToString()).ToArray()).ToArray());

        protected void InputOutputTest(string[][] input, string[][] expectedOutput)
            =>
                InputOutputTest(input.Select(x => string.Join(Separator, x)).ToArray(),
                    expectedOutput.Select(x => string.Join(Separator, x)).ToArray());

        protected void InputOutputTest(string[] input, string[] expectedOutput)
            =>
                InputOutputTest(string.Join(Environment.NewLine, input),
                    string.Join(Environment.NewLine, expectedOutput));

        protected void InputOutputTest(string input, string expectedOutput)
        {
            using (var reader = new StringReader(input))
            using (var writer = new StringWriter())
            {
                Console.SetIn(reader);
                Console.SetOut(writer);
                _testAction();
                Assert.That(expectedOutput.Trim(), Is.EqualTo(writer.ToString().Trim()));
            }
        }
    }
}
