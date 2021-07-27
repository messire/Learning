using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class ReverseIntegerTests : BaseTest<ReverseInteger>
    {
        private void CheckResult(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseInteger_Test1()
        {
            int integer = 123;
            int expected = 321;
            int result = Tester.Calculate(integer);
            CheckResult(result, expected);
        }

        [Test]
        public void ReverseInteger_Test2()
        {
            int integer = -120;
            int expected = -21;
            int result = Tester.Calculate(integer);
            CheckResult(result, expected);
        }

        [Test]
        public void ReverseInteger_Test3()
        {
            int integer = 1;
            int expected = 1;
            int result = Tester.Calculate(integer);
            CheckResult(result, expected);
        }
    }
}