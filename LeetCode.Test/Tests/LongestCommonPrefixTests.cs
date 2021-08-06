using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class LongestCommonPrefixTests: BaseTest<LongestCommonPrefix>
    {
        private void CheckResult(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongestCommonPrefix_Test1()
        {
            string[] s = {"flower", "flow", "flight"};
            string expected = "fl";
            string result = Tester.Calculate(s);
            CheckResult(result, expected);
        }
        
        [Test]
        public void LongestCommonPrefix_Test2()
        {
            string[] s = {"dog","racecar","car"};
            string expected = "";
            string result = Tester.Calculate(s);
            CheckResult(result, expected);
        }
        
        [Test]
        public void LongestCommonPrefix_Test3()
        {
            string[] s = {"cir","car"};
            string expected = "c";
            string result = Tester.Calculate(s);
            CheckResult(result, expected);
        }
    }
}