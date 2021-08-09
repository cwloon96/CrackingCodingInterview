namespace CrackingCodingInterview.Model
{
    public class ListNode<T>
    {
        public T Value;

        public ListNode<T> Next;

        public ListNode(T val, ListNode<T> next = null)
        {
            Value = val;
            Next = next;
        }
    }
}