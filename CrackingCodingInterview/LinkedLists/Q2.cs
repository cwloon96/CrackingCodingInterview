using CrackingCodingInterview.Model;

namespace CrackingCodingInterview.LinkedLists
{
    public class Q2
    {
        public int ReturnKthToLastS1(ListNode<int> node, int lastKth)
        {
            int totalCount = 0;
            var temp = node;

            while (temp != null)
            {
                totalCount++;
                temp = temp.Next;
            }

            int resultIndex = totalCount - lastKth + 1;
            int index = 0;
            while(node != null)
            {
                index++;

                if (index == resultIndex)
                    return node.Value;

                node = node.Next;
            }


            return -1;
        }

        public int ReturnKthToLastS2(ListNode<int> node, int lastKth)
        {
            int result = 0;
            ReturnKthToLastS2(node, lastKth, ref result);

            return result;
        }

        private int ReturnKthToLastS2(ListNode<int> node, int lastKth, ref int result)
        {
            if (node == null)
                return 0;

            int lastKthIndex = ReturnKthToLastS2(node.Next, lastKth, ref result) + 1;
            if (lastKthIndex == lastKth)
                result = node.Value;

            return lastKthIndex;
        }

        public int ReturnKthToLastS3(ListNode<int> node, int lastKth)
        {
            var temp1 = node;
            var temp2 = node;

            for (int i = 0; i < lastKth; i++)
                temp1 = temp1.Next;

            while (temp1 != null)
            {
                temp1 = temp1.Next;
                temp2 = temp2.Next;
            }

            return temp2.Value;
        }
    }
}