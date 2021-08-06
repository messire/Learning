using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class RomanToIntegerTests : BaseTest<RomanToInteger>
    {
        private void CheckResult(int expected, int actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IntegerToRoman_Test1()
        {
            string num = "III";
            int expected = 3;
            int result = Tester.Calculate(num);
            CheckResult(expected, result);
        }
        
        [Test]
        public void IntegerToRoman_Test2()
        {
            string num = "IV";
            int expected = 4;
            int result = Tester.Calculate(num);
            CheckResult(expected, result);
        }
        
        [Test]
        public void IntegerToRoman_Test3()
        {
            string num = "IX";
            int expected = 9;
            int result = Tester.Calculate(num);
            CheckResult(expected, result);
        }
        
        [Test]
        public void IntegerToRoman_Test4()
        {
            string num = "LVIII";
            int expected = 58;
            int result = Tester.Calculate(num);
            CheckResult(expected, result);
        }
        
        [Test]
        public void IntegerToRoman_Test5()
        {
            string num = "MCMXCIV";
            int expected = 1994;
            int result = Tester.Calculate(num);
            CheckResult(expected, result);
        }
    }
}