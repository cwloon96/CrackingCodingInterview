using CrackingCodingInterview.Model;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q8
    {
        public ListNode<int> FindLoopBeginningS1(ListNode<int> node)
        {
            var fast = node;
            var slow = node;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    break;
            }

            // no loop found
            if (fast == null || fast.Next == null)
                return null;

            slow = node;

            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return fast;
        }
    }
}