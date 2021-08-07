namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q3
    {
        public void UrlifyS1(char[] s, int trueLength)
        {
            var spaceCount = 0;
            for (int i = 0; i < trueLength; i++)
                if (s[i] == ' ')
                    spaceCount++;

            var newTrueLength = trueLength - spaceCount + (spaceCount * 3);
            s[newTrueLength] = '\0';

            for (int left = trueLength - 1, right = newTrueLength - 1; left >= 0; left--)
            {
                if (s[left] == ' ')
                {
                    s[right--] = '0';
                    s[right--] = '2';
                    s[right--] = '%';
                }
                else
                {
                    s[right--] = s[left];
                }
            }
        }
    }
}