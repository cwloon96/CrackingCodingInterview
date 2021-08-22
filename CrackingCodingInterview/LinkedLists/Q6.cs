using CrackingCodingInterview.Model;
using System.Collections.Generic;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q6
    {
        public bool IsPalindromeS1(ListNode<char> node)
        {
            var stack = new Stack<char>();

            ListNode<char> slow = node;
            ListNode<char> fast = node;

            while (fast != null && fast.Next != null)
            {
                stack.Push(slow.Value);

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            // if length is odd, fast will be last element & slow will be at middle element
            if (fast != null)
                slow = slow.Next;

            while (slow != null)
            {
                if (stack.Pop() != slow.Value)
                    return false;

                slow = slow.Next;
            }

            return true;
        }

        public bool IsPalindromeS2(ListNode<char> node)
        {
            var reversedNode = CloneReversed(node);

            while (node != null)
            {
                if (node.Value != reversedNode.Value)
                    return false;

                node = node.Next;
                reversedNode = reversedNode.Next;
            }

            return true;
        }

        public ListNode<char> CloneReversed(ListNode<char> node)
        {
            ListNode<char> head = null;

            while (node != null)
            {
                var newNode = new ListNode<char>(node.Value, head);
                head = newNode;
                node = node.Next;
            }

            return head;
        }
    }
}