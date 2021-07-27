using LeetCode.Helpers;

namespace LeetCode
{
    // You are given two non-empty linked lists representing two non-negative integers.
    // The digits are stored in reverse order, and each of their nodes contains a single digit.
    // Add the two numbers and return the sum as a linked list.
    // You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    public class AddTwoNumbers
    {
        public ListNode Calculate(ListNode l1, ListNode l2, int bit = 0)
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

            return new ListNode(sum, Calculate(l1?.next, l2?.next, bit));
        }
    }
}