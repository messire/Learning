using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    [TestFixture]
    public class MedianSortedArraysTests : BaseTest<MedianSortedArrays>
    {
        private void CheckResult(double actual, double expected)
        {
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void MedianSortedArrays_Test1()
        {
            int[] nums1 = new[] {1, 3};
            int[] nums2 = new[] {2};
            double result = Tester.Calculate(nums1, nums2);
            double expected = 2.0;
            CheckResult(result, expected);
        }
        
        [Test]
        public void MedianSortedArrays_Test2()
        {
            int[] nums1 = new[] {1, 2};
            int[] nums2 = new[] {3, 4};
            double result = Tester.Calculate(nums1, nums2);
            double expected = 2.5;
            CheckResult(result, expected);
        }
        
        [Test]
        public void MedianSortedArrays_Test3()
        {
            int[] nums1 = new[] {0, 0};
            int[] nums2 = new[] {0};
            double result = Tester.Calculate(nums1, nums2);
            double expected = 0.0;
            CheckResult(result, expected);
        }
        
        [Test]
        public void MedianSortedArrays_Test4()
        {
            int[] nums1 = new int[] { };
            int[] nums2 = new[] {1};
            double result = Tester.Calculate(nums1, nums2);
            double expected = 1.0;
            CheckResult(result, expected);
        }
        
        [Test]
        public void MedianSortedArrays_Test5()
        {
            int[] nums1 = new[] {2};
            int[] nums2 = new int[] { };
            double result = Tester.Calculate(nums1, nums2);
            double expected = 2.0;
            CheckResult(result, expected);
        }
    }
}