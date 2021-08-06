using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class IntegerToRomanTests : BaseTest<IntegerToRoman>
    {
        private void CheckResult(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IntegerToRoman_Test1()
        {
            int num = 3;
            string expected = "III";
            string result = Tester.Calculate(num);
            CheckResult(expected, result);
        }

        [Test]
        public void IntegerToRoman_Test2()
        {
            int num = 4;
            string expected = "IV";
            string result = Tester.Calculate(num);
            CheckResult(expected, result);
        }

        [Test]
        public void IntegerToRoman_Test3()
        {
            int num = 9;
            string expected = "IX";
            string result = Tester.Calculate(num);
            CheckResult(expected, result);
        }

        [Test]
        public void IntegerToRoman_Test4()
        {
            int num = 58;
            string expected = "LVIII";
            string result = Tester.Calculate(num);
            CheckResult(expected, result);
        }

        [Test]
        public void IntegerToRoman_Test5()
        {
            int num = 1994;
            string expected = "MCMXCIV";
            string result = Tester.Calculate(num);
            CheckResult(expected, result);
        }
    }
}