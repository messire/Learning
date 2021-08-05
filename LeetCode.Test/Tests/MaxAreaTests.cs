using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class MaxAreaTests : BaseTest<MaxArea>
    {
        private void CheckResult(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseInteger_Test1()
        {
            int[] height = {1, 8, 6, 2, 5, 4, 8, 3, 7};
            int expected = 49;
            int result = Tester.Calculate(height);
            CheckResult(result, expected);
        }

        [Test]
        public void ReverseInteger_Test2()
        {
            int[] height = {1, 1};
            int expected = 1;
            int result = Tester.Calculate(height);
            CheckResult(result, expected);
        }

        [Test]
        public void ReverseInteger_Test3()
        {
            int[] height = {4, 3, 2, 1, 4};
            int expected = 16;
            int result = Tester.Calculate(height);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ReverseInteger_Test4()
        {
            int[] height = {1, 2, 1};
            int expected = 2;
            int result = Tester.Calculate(height);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ReverseInteger_Test5()
        {
            int[] height = BigCollections.MaxAreaCollection;
            int expected = 705634720;
            int result = Tester.Calculate(height);
            CheckResult(result, expected);
        }
        
        [Test]
        public void ReverseInteger_Test6()
        {
            int[] height = { 3, 2, 5, 8, 1, 6, 7, 4, 9, 3, 2, 6 };
            int expected = 48;
            int result = Tester.Calculate(height);
            CheckResult(result, expected);
        }
    }
}