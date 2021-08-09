namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q9
    {
        public bool StringRotationS1(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                var s1s1 = s1 + s1;

                for (int i = 0; i < s1s1.Length; i ++)
                {
                    if (s1s1[i] == s2[0])
                    {
                        if (s1s1.Substring(i, s2.Length) == s2)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}