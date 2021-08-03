using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class RegularExpressionMatchingTests: BaseTest<RegularExpressionMatching>
    {
        private void CheckResult(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseInteger_Test1()
        {
            string s = "aa";
            string p = "a";
            bool result = Tester.Calculate(s, p);
            CheckResult(result, false);
        }
        
        [Test]
        public void ReverseInteger_Test2()
        {
            string s = "aa";
            string p = "a*";
            bool result = Tester.Calculate(s, p);
            CheckResult(result, true);
        }
        
        [Test]
        public void ReverseInteger_Test3()
        {
            string s = "ab";
            string p = ".*";
            bool result = Tester.Calculate(s, p);
            CheckResult(result, true);
        }
        
        [Test]
        public void ReverseInteger_Test4()
        {
            string s = "aab";
            string p = "c*a*b";
            bool result = Tester.Calculate(s, p);
            CheckResult(result, true);
        }
        
        [Test]
        public void ReverseInteger_Test5()
        {
            string s = "mississippi";
            string p = "mis*is*p*.";
            bool result = Tester.Calculate(s, p);
            CheckResult(result, false);
        }
    }
}