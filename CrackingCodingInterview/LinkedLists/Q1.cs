using CrackingCodingInterview.Model;
using System.Collections.Generic;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q1
    {
        public void RemoveDupS1(ListNode<int> node)
        {
            var set = new HashSet<int>();
            ListNode<int> previous = null;

            while (node != null)
            {
                if (set.Contains(node.Value))
                {
                    previous.Next = node.Next;
                }
                else
                {
                    set.Add(node.Value);
                    previous = node;
                }
                node = node.Next;
            }
        }

        // Follow up, without temp buffer
        public void RemoveDupS2(ListNode<int> node)
        {
            while (node != null)
            {
                var current = node;
                
                while (current.Next != null)
                {
                    if (current.Next.Value == node.Value)
                    {
                        current.Next = current.Next.Next;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                node = node.Next;
            }
        }
    }
}