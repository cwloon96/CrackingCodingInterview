using System;
using System.Text;

namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q6
    {
        public string StringCompressionS1(string s)
        {
            StringBuilder sb = new StringBuilder();

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count++;

                if (i + 1 >= s.Length || s[i] != s[i + 1])
                {
                    sb.Append(s[i]);
                    sb.Append(count);
                    count = 0;
                }
            }

            if (sb.Length < s.Length)
                return sb.ToString();

            return s;
        }

        public string StringCompressionS2(string s)
        {
            int finalLength = CalculateCompressedLength(s);
            if (finalLength >= s.Length)
                return s;

            StringBuilder sb = new StringBuilder(finalLength);

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count++;

                if (i + 1 >= s.Length || s[i] != s[i + 1])
                {
                    sb.Append(s[i]);
                    sb.Append(count);
                    count = 0;
                }
            }

            if (sb.Length < s.Length)
                return sb.ToString();

            return s;
        }

        private int CalculateCompressedLength(string s)
        {
            int length = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count++;

                if (i + 1 >= s.Length || s[i] != s[i + 1])
                {
                    // 1 + count length = character + repeat count length
                    length += 1 + GetIntLength(count);
                    count = 0;
                }
            }

            return length;
        }

        private int GetIntLength(int value)
        {
            // eg: log(10)10 = 1 + 1 = 2
            // eg: log(10)100 = 2 + 1 = 3
            return (int)Math.Floor(Math.Log10(value)) + 1;
        }
    }
}