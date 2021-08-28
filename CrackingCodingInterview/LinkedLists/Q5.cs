using CrackingCodingInterview.Model;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q5
    {
        public ListNode<int> SumListS1(ListNode<int> l1, ListNode<int> l2)
        {
            return SumListS1(l1, l2, 0);
        }

        private ListNode<int> SumListS1(ListNode<int> l1, ListNode<int> l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0)
                return null;

            int result = (l1?.Value ?? 0) + (l2?.Value ?? 0) + carry;

            return new ListNode<int>(result % 10, SumListS1(l1?.Next, l2?.Next, result > 10 ? 1 : 0));
        }

        public ListNode<int> SumListFollowUpS1(ListNode<int> l1, ListNode<int> l2)
        {
            int length1 = GetLength(l1);
            int length2 = GetLength(l2);

            if (length1 > length2)
            {
                AppendFront(l2, length1 - length2);
            }
            else if (length2 < length1)
            {
                AppendFront(l1, length2 - length1);
            }

            var result = Sum(l1, l2);

            if (result.Item2 == 0)
                return result.Item1;

            return new ListNode<int>(result.Item2, result.Item1);
        }

        private int GetLength(ListNode<int> node)
        {
            int length = 0;
            var temp = node;
            while (temp != null)
            {
                temp = temp.Next;
                length++;
            }

            return length;
        }

        private void AppendFront(ListNode<int> node, int count)
        {
            var head = node;

            while (count > 0)
            {
                head = new ListNode<int>(0, head);
                count--;
            }
        }

        // result listnode, carry
        private (ListNode<int>, int) Sum(ListNode<int> l1, ListNode<int> l2)
        {
            if (l1 == null && l2 == null)
                return (null, 0);

            var next = Sum(l1.Next, l2.Next);

            var result = (l1?.Value ?? 0) + (l2?.Value ?? 0) + next.Item2;

            return (new ListNode<int>(result % 10, next.Item1), result > 10 ? 1 : 0);
        }
    }
}