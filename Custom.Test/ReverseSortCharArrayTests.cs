using NUnit.Framework;

namespace Custom.Test
{
    [TestFixture]
    public class ReverseSortCharArrayTests : BaseTest<ReverseSortCharArray>
    {
        private void CheckResult(char[] actual, char[] expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseSortCharArray_Text1()
        {
            char[] array = new char[] {'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', ' ', '!'};
            char[] expected = new char[] {'!', ' ', 'w', 'o', 'r', 'l', 'd', ' ', 'h', 'e', 'l', 'l', 'o'};
            char[] result = Tester.Calculate(array);
            CheckResult(result, expected);
        }

        [Test]
        public void ReverseSortCharArray_Text2()
        {
            char[] array = new char[] {'a', ' ', 'b', ' ', 'c'};
            char[] expected = new char[] {'c', ' ', 'b', ' ', 'a'};
            char[] result = Tester.Calculate(array);
            CheckResult(result, expected);
        }

        [Test]
        public void ReverseSortCharArray_Text3()
        {
            char[] array = new char[]
                {'h', 'a', 'v', 'e', ' ', 'm', 'o', 'r', 'e', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e'};
            char[] expected = new char[]
                {'p', 'r', 'a', 'c', 't', 'i', 'c', 'e', ' ', 'm', 'o', 'r', 'e', ' ', 'h', 'a', 'v', 'e'};
            char[] result = Tester.Calculate(array);
            CheckResult(result, expected);
        }
    }
}