using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    [TestFixture]
    public class LongestPalindromeTests : BaseTest<LongestPalindrome>
    {
        private void CheckResult(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongestPalindrome_Test1()
        {
            string s = "bb";
            string result = Tester.Calculate(s);
            string expected = "bb";
            CheckResult(result, expected);
        }

        [Test]
        public void LongestPalindrome_Test2()
        {
            string s = "ccc";
            string result = Tester.Calculate(s);
            string expected = "ccc";
            CheckResult(result, expected);
        }

        [Test]
        public void LongestPalindrome_Test3()
        {
            string s = "aaca";
            string result = Tester.Calculate(s);
            string expected = "aca";
            CheckResult(result, expected);
        }

        [Test]
        public void LongestPalindrome_Test4()
        {
            string s = "babad";
            string result = Tester.Calculate(s);
            string expected = "bab";
            CheckResult(result, expected);
        }

        [Test]
        public void LongestPalindrome_Test5()
        {
            string s = "cbbd";
            string result = Tester.Calculate(s);
            string expected = "bb";
            CheckResult(result, expected);
        }

        [Test]
        public void LongestPalindrome_Test6()
        {
            string s = "a";
            string result = Tester.Calculate(s);
            string expected = "a";
            CheckResult(result, expected);
        }

        [Test]
        public void LongestPalindrome_Test7()
        {
            string s = "ac";
            string result = Tester.Calculate(s);
            string expected = "a";
            CheckResult(result, expected);
        }
    }
}