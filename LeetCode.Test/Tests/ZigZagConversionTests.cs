using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class ZigZagConversionTests: BaseTest<ZigZagConversion>
    {
        private void CheckResult(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ZigZagConversion_Test1()
        {
            string s = "PAYPALISHIRING";
            string target = "PAHNAPLSIIGYIR";
            int numRows = 3;
            string result = Tester.Calculate(s, numRows);

            CheckResult(result, target);
        }
        
        [Test]
        public void ZigZagConversion_Test2()
        {
            string s = "PAYPALISHIRING";
            string target = "PINALSIGYAHRPI";
            int numRows = 4;
            string result = Tester.Calculate(s, numRows);

            CheckResult(result, target);
        }
        
        [Test]
        public void ZigZagConversion_Test3()
        {
            string s = "A";
            string target = "A";
            int numRows = 1;
            string result = Tester.Calculate(s, numRows);

            CheckResult(result, target);
        }
        
        [Test]
        public void ZigZagConversion_Test4()
        {
            string s = "AB";
            string target = "AB";
            int numRows = 1;
            string result = Tester.Calculate(s, numRows);

            CheckResult(result, target);
        }
        
        [Test]
        public void ZigZagConversion_Test5()
        {
            string s = "A";
            string target = "A";
            int numRows = 2;
            string result = Tester.Calculate(s, numRows);

            CheckResult(result, target);
        }
    }
}