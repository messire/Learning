using System.Collections.Generic;
using System.Linq;
using LeetCode.Helpers;

namespace LeetCode
{
    // Given an n-ary tree, return the level order traversal of its nodes' values.
    //
    // Nary-Tree input serialization is represented in their level order traversal,
    // each group of children is separated by the null value

    // Constraints:
    //
    // The height of the n-ary tree is less than or equal to 1000
    // The total number of nodes is between [0, 10^4]

    // Definition for a Node.
    /*
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
    */

    public class NTreeLevelOrderTraversal
    {
        public IList<IList<int>> Calculate(Node root)
        {
            IList<IList<int>> result = new List<IList<int>> ();

            if (root == null) return result;
            
            result.Add(new List<int>() { root.val });
            
            List<Node> nodes = new List<Node>(root.children);
            while (nodes.Count > 0)
            {
                List<int> parsed = Parse(nodes);
                result.Add(parsed);

                List<Node> temp = nodes;
                nodes = new List<Node>();

                foreach (Node node in temp)
                {
                    if (node.children == null) continue;
                    nodes.AddRange(new List<Node>(node.children));
                }
            }


            return result;
        }

        private List<int> Parse(List<Node> nodes)
        {
            return nodes.Select(node => node.val).ToList();
        }
    }
}