using System.Collections.Generic;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode.Test.Tests
{
    public class NTreeLevelOrderTraversalTests : BaseTest<NTreeLevelOrderTraversal>
    {
        private void CheckResult(IList<IList<int>> actual, IList<IList<int>> expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongestCommonPrefix_Test1()
        {
            Node node = new Node(1, new List<Node>
            {
                new Node(3, new List<Node>
                {
                    new Node(5),
                    new Node(6)
                }),
                new Node(2),
                new Node(4)
            });
            
            IList<IList<int>> expected = new List<IList<int>>
                { new List<int> { 1 }, new List<int> { 3, 2, 4 }, new List<int> { 5, 6 } };
            IList<IList<int>> result = Tester.Calculate(node);
            CheckResult(result, expected);
        }
    }
}