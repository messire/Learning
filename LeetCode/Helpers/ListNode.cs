namespace LeetCode.Helpers
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

        public override bool Equals(object obj)
        {
            if (!(obj is ListNode other)) return false;

            return val == other.val && (next == null && other.next == null || next.Equals(other.next));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (val * 397) ^ (next != null ? next.GetHashCode() : 0);
            }
        }
    }
}