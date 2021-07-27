using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    [TestFixture]
    public class TwoSumTests : BaseTest<TwoSum>
    {
        private void CheckResult(int[] nums, int[] array, int expectedSum)
        {
            int actualSum = nums[array[0]] + nums[array[1]];
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void TwoSum_Test1()
        {
            int[] nums = new[] {2, 7, 11, 15};
            int target = 18;
            int[] result = Tester.Calculate(nums, target);
            CheckResult(nums, result, target);
        }

        [Test]
        public void TwoSum_Test2()
        {
            int[] nums = new[] {3, 2, 4};
            int target = 7;
            int[] result = Tester.Calculate(nums, target);
            CheckResult(nums, result, target);
        }

        [Test]
        public void TwoSum_Test3()
        {
            int[] nums = new[] {3, 3};
            int target = 6;
            int[] result = Tester.Calculate(nums, target);
            CheckResult(nums, result, target);
        }
    }
}