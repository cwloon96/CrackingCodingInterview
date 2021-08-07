using System;

namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q2
    {
        public bool CheckPermutationS1(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var sortedS1 = GetSortedArr(s1);
            var sortedS2 = GetSortedArr(s2);

            for (int i = 0; i < sortedS1.Length; i++)
            {
                if (sortedS1[i] != sortedS2[i])
                    return false;
            }

            return true;
        }

        private char[] GetSortedArr(string s)
        {
            var arr = s.ToCharArray();
            Array.Sort(arr);
            return arr;
        }

        // works for ASCII only as arr fixed to 128
        public bool CheckPermutationS2(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var arr = new int[128];

            for (int i = 0; i < s1.Length; i++)
                arr[s1[i]]++;
            
            for (int i = 0; i < s2.Length; i++)
            {
                arr[s2[i]]--;

                // both string mush be same size, thus extra character must be < 0
                // eg: s1 = abc, s2 = abz, z will be < 0 in this case
                if (arr[s2[i]] < 0)
                    return false;
            }

            return true;
        }
    }
}