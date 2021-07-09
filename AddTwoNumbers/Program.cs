using System;

namespace AddTwoNumbers
{
    // You are given two non-empty linked lists representing two non-negative integers.
    // The digits are stored in reverse order, and each of their nodes contains a single digit.
    // Add the two numbers and return the sum as a linked list.
    // You may assume the two numbers do not contain any leading zero, except the number 0 itself.


    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

            public override string ToString()
            {
                return $" {val} {next}";
            }
        }

        public static void Main(string[] args)
        {
            // Input: l1 = [2,4,3], l2 = [5,6,4]
            // Output: [7,0,8]
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            //Console.WriteLine(AddTwoNumbers(l1, l2));
            Console.WriteLine(AddTwoNumbers2(l1, l2));

            // Input: l1 = [0], l2 = [0]
            // Output: [0]
            l1 = new ListNode();
            l2 = new ListNode();

            Console.WriteLine(AddTwoNumbers(l1, l2));

            // Input: l1 = [9], l2 = [1,9,9,9,9,9,9,9,9,9]
            // Output: [0,0,0,0,0,0,0,0,0,0,1]

            l1 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))))));
            l2 = new ListNode(9);

            ListNode result = AddTwoNumbers(l1, l2);
            Console.WriteLine(result);
        }

        #region Solution 1

        //Result complexity O(n)
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = GetNode(l1, l2, 0);
            return result;
        }

        public static ListNode GetNode(ListNode l1, ListNode l2, int bit)
        {
            if (l1 == null && l2 == null)
            {
                return bit == 1 ? new ListNode(bit) : null;
            }

            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + bit;
            bit = 0;

            if (sum > 9)
            {
                bit++;
                sum -= 10;
            }

            return new ListNode(sum, GetNode(l1?.next, l2?.next, bit));
        }

        #endregion

        #region Solution 2

        public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            int bit = 0;
            ListNode result = new ListNode();
            ListNode current = result;
            while (l1 != null || l2 != null)
            {
                int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + bit;
                bit = sum / 10;
                sum -= 10 * bit;
                current.next = new ListNode(sum);
                current = current.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (bit > 0)
            {
                current.next = new ListNode(bit);
            }

            return result.next;
        }

        #endregion
    }
}