namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q5
    {
        public bool OneAwayS1(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return OneAwayS1(s2, s1);

            if (s2.Length - s1.Length > 1)
                return false;

            bool changed = false;
            for (int i = 0, j = 0; i < s1.Length; i++, j++)
            {
                if (s1[i] != s2[j])
                {
                    if (changed)
                        return false;

                    changed = true;

                    if (s1.Length != s2.Length)
                        j++;
                }
            }

            return true;
        }
    }
}