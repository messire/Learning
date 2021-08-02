using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    [TestFixture]
    public class StringToInteger_ATOITests : BaseTest<StringToInteger_ATOI>
    {
        private void CheckResult(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ATOI_Test1()
        {
            string str = "42";
            int expected = 42;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test2()
        {
            string str = "   -42";
            int expected = -42;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test3()
        {
            string str = "4193 with words";
            int expected = 4193;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test4()
        {
            string str = "words and 987";
            int expected = 0;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test5()
        {
            string str = "-91283472332";
            int expected = -2147483648;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test6()
        {
            string str = "3.14159";
            int expected = 3;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
                
        [Test]
        public void ATOI_Test7()
        {
            string str = "-+12";
            int expected = 0;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test8()
        {
            string str = "";
            int expected = 0;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test9()
        {
            string str = "+1";
            int expected = 1;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ATOI_Test10()
        {
            string str = "20000000000000000000";
            int expected = 2147483647;
            int result = Tester.Calculate(str);
            CheckResult(result, expected);
        }
    }
}