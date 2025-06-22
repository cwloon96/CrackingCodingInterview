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
            for (int i = 0, j = 0; i < s1.Length && j < s2.Length; j++)
            {
                if (s1[i] != s2[j])
                {
                    if (changed)
                        return false;

                    changed = true;

                    // if both same length, it is an edit and continue to compare the next one
                    // else it is an delete, only increase j to compare the next one
                    if (s1.Length == s2.Length)
                        i++;
                }
                else
                {
                    i++;
                }
            }

            return true;
        }
    }
}