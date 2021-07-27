using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    [TestFixture]
    public class AddTwoNumbersTests: BaseTest<AddTwoNumbers>
    {
        private void CheckResult(ListNode actual, ListNode expected)
        {
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void AddTwoNumbers_Test1()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode expected = new ListNode(7, new ListNode(0, new ListNode(8)));
            ListNode result = Tester.Calculate(l1, l2);
            
            CheckResult(result, expected);
        }

        [Test]
        public void AddTwoNumbers_Test2()
        {
            ListNode l1 = new ListNode();
            ListNode l2 = new ListNode();
            ListNode expected = new ListNode();
            ListNode result = Tester.Calculate(l1, l2);

            CheckResult(result, expected);
        }

        [Test]
        public void AddTwoNumbers_Test3()
        {
            ListNode l1 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9,
                new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9,
                    new ListNode(9, new ListNode(9))))))))));
            ListNode l2 = new ListNode(9);

            ListNode expected = new ListNode(0, new ListNode(0, new ListNode(0,
                new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0,
                    new ListNode(0, new ListNode(0, new ListNode(0,
                        new ListNode(1)))))))))));
            ListNode result = Tester.Calculate(l1, l2);

            CheckResult(result, expected);
        }
    }
}