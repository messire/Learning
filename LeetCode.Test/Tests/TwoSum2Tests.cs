using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    [TestFixture]
    public class TwoSum2Tests : BaseTest<TwoSum2>
    {
        private void CheckResult(int[] nums, int[] result, int expectedSum)
        {
            int indexA = result[0] - 1;
            int indexB = result[1] - 1;
            
            int actualSum = nums[indexA] + nums[indexB];
            Assert.AreEqual(expectedSum, actualSum);
            Assert.True(result[0] < result[1]);
        }

        [Test]
        public void TwoSum2_Test1()
        {
            int[] nums = new[] {2, 7, 11, 15};
            int target = 9; // [1, 2]
            int[] result = Tester.Calculate(nums, target);
            CheckResult(nums, result, target);
        }

        [Test]
        public void TwoSum2_Test2()
        {
            int[] nums = new[] {2, 3, 4};
            int target = 6;
            int[] result = Tester.Calculate(nums, target);
            CheckResult(nums, result, target);
        }

        [Test]
        public void TwoSum2_Test3()
        {
            int[] nums = new[] {-1, 0};
            int target = -1;
            int[] result = Tester.Calculate(nums, target);
            CheckResult(nums, result, target);
        }
    }
}