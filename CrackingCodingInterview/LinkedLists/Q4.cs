using CrackingCodingInterview.Model;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q4
    {
        public ListNode<int> PartitionS1(ListNode<int> node, int partition)
        {
            ListNode<int> lessThan = null; // keep track nodes < partition
            ListNode<int> afterLess = null; // keep track last node in lessThan

            ListNode<int> moreThan = null; // keep track nodes >= partition
            ListNode<int> afterMore = null; // keep track last node in moreThan

            while (node != null)
            {
                var next = node.Next;
                node.Next = null;

                if (node.Value < partition)
                {
                    if (lessThan == null)
                        lessThan = node;
                    else
                        afterLess.Next = node;

                    afterLess = node;
                }
                else
                {
                    if (moreThan == null)
                        moreThan = node;
                    else
                        afterMore.Next = node;

                    afterMore = node;
                }

                node = next;
            }

            if (lessThan == null)
                return moreThan;

            afterLess.Next = moreThan;
            return lessThan;
        }

        public ListNode<int> PartitionS2(ListNode<int> node, int partition)
        {
            var head = node;
            var tail = node;

            while (node != null)
            {
                var next = node.Next;

                if (node.Value < partition)
                {
                    node.Next = head;
                    head = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;    
                }

                node = next;
            }

            tail.Next = null;

            return head;
        }
    }
}