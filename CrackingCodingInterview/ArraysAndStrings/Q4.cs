namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q4
    {
        public bool PalindromePermutationS1(string str)
        {
            // store a - z
            var arr = new int[26];

            for (int i = 0; i < str.Length; i++)
                if ('a' <= str[i] && str[i] <= 'z')
                    arr[str[i] - 'a']++;

            bool hasOdd = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] & 1) != 0)
                {
                    if (hasOdd)
                        return false;

                    hasOdd = true;
                }
            }

            return true;
        }

        // enhanced version of S1
        public bool PalindromePermutationS2(string str)
        {
            // store a - z
            var arr = new int[26];
            int oddCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ('a' <= str[i] && str[i] <= 'z')
                {
                    int index = str[i] - 'a';
                    arr[index]++;

                    if ((arr[index] & 1) == 0)
                        oddCount--;
                    else
                        oddCount++;
                }
            }

            return oddCount <= 1;
        }

        public bool PalindromePermutationS3(string str)
        {
            int checker = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ('a' <= str[i] && str[i] <= 'z')
                {
                    int shift = str[i] - 'a';
                    int value = 1 << shift;
                    // check if the bit position has been triggered
                    // eg: 0010 & 0010 = 2 -> triggered, reverse to 0
                    // eg: 0000 & 0010 = 0 -> not triggered, reverse to 1
                    if ((checker & value) == 0)
                    {
                        // 0000 |= 0010 = 0010, reverse 0 to 1
                        checker |= value;
                    }
                    else
                    {
                        // ~0010 -> 1101
                        // 0010 & 1101 = 0, reverse 1 to 0
                        checker &= ~value;
                    }
                }
            }

            // checker = 0 -> all characters appears even times
            // 0010 & 0001 = 0 -> only one character appears odd times
            return checker == 0 || ((checker & (checker - 1)) == 0);
        }
    }
}