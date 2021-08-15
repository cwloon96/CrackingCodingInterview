using CrackingCodingInterview.Model;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q3
    {
        public void DeleteMiddleNodeS1(ListNode<int> node)
        {
            if (node.Next != null)
            {
                node.Value = node.Next.Value;
                node.Next = node.Next.Next;
            }
        }
    }
}