using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class PalindromeNumberTests : BaseTest<PalindromeNumber>
    {
        private void CheckResult(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseInteger_Test1()
        {
            int integer = 123;
            bool result = Tester.Calculate(integer);
            CheckResult(result, false);
        }
        
        [Test]
        public void ReverseInteger_Test2()
        {
            int integer = 1;
            bool result = Tester.Calculate(integer);
            CheckResult(result, true);
        }
        
        [Test]
        public void ReverseInteger_Test3()
        {
            int integer = 10;
            bool result = Tester.Calculate(integer);
            CheckResult(result, false);
        }
        [Test]
        public void ReverseInteger_Test4()
        {
            int integer = 11;
            bool result = Tester.Calculate(integer);
            CheckResult(result, true);
        }
        [Test]
        public void ReverseInteger_Test5()
        {
            int integer = 1111;
            bool result = Tester.Calculate(integer);
            CheckResult(result, true);
        }
    }
}