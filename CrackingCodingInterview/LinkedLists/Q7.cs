using CrackingCodingInterview.Model;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q7
    {
        public ListNode<int> FindIntersectionS1(ListNode<int> l1, ListNode<int> l2)
        {
            var result1 = GetLastNodeAndLength(l1);
            var result2 = GetLastNodeAndLength(l2);

            if (result1.Item1 != result2.Item1)
                return null;

            if (result1.Item2 > result2.Item2)
            {
                l1 = MoveForward(l1, result1.Item2 - result2.Item2);
            }
            else if (result2.Item2 > result1.Item2)
            {
                l2 = MoveForward(l2, result2.Item2 - result1.Item2);
            }

            while (l1 != l2)
            {
                l1 = l1.Next;
                l2 = l2.Next;
            }

            return l1;
        }

        private (ListNode<int>, int) GetLastNodeAndLength(ListNode<int> node)
        {
            int length = 0;
            var temp = node;

            while (temp.Next != null)
            {
                length++;
                temp = temp.Next;
            }

            return (temp, length);
        }

        private ListNode<int> MoveForward(ListNode<int> node, int steps)
        {
            for (int i = steps; i > 0; i--)
                node = node.Next;

            return node;
        }
    }
}