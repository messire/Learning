using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    [TestFixture]
    public class LongestSubstringTests : BaseTest<LongestSubstring>
    {
        private void CheckResult(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void LongestSubstring_Test1()
        {
            string s = "abcabcbb";
            int result = Tester.Calculate(s);
            int expected = 3;
            CheckResult(result, expected);
        }
        
        [Test]
        public void LongestSubstring_Test2()
        {
            string s = "bbbbb";
            int result = Tester.Calculate(s);
            int expected = 1;
            CheckResult(result, expected);
        }
        
        [Test]
        public void LongestSubstring_Test3()
        {
            string s = "pwwkew";
            int result = Tester.Calculate(s);
            int expected = 3;
            CheckResult(result, expected);
        }
        
        [Test]
        public void LongestSubstring_Test4()
        {
            string s = "";
            int result = Tester.Calculate(s);
            int expected = 0;
            CheckResult(result, expected);
        }
        
        [Test]
        public void LongestSubstring_Test5()
        {
            string s = "dvdf";
            int result = Tester.Calculate(s);
            int expected = 3;
            CheckResult(result, expected);
        }
    }
}