using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q1
    {
        // works for ASCII & Unicode
        public bool IsUniqueS1(string str)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                    return false;

                dict.Add(str[i], 1);
            }

            return true;
        }

        // works for ASCII only as the arr size is fixed
        public bool IsUniqueS2(string str)
        {
            var arr = new int[128];
            for (int i = 0; i < str.Length; i++)
            {
                arr[str[i]]++;

                if (arr[str[i]] > 1)
                    return false;
            }

            return true;
        }

        // works for a-z only, without additional data structure
        public bool IsUniqueS3(string str)
        {
            var checker = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                    return false;

                checker |= (1 << val);
            }

            return true;
        }

        public bool IsUniqueS4(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        return false;
                }
            }

            return true;
        }

        public bool IsUniqueS5(string str)
        {
            var strArr = str.ToCharArray();
            Array.Sort(strArr);

            for (int i = 1; i < strArr.Length; i++)
            {
                if (strArr[i] == strArr[i - 1])
                    return false;
            }

            return true;
        }
    }
}