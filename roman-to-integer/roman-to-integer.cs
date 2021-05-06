public class Solution {
    public int RomanToInt(string s) {
        /*Algorthim
             * 1. Create dictionary
             * 2. Read input string -> interpret string with dictionary
             * 3. Convert string value to int, using dictionary
             * 4. Return int result
            */
            Dictionary<char, int> romDict = new Dictionary<char, int>();
            romDict.Add('I', 1);
            romDict.Add('V', 5);
            romDict.Add('X', 10);
            romDict.Add('L', 50);
            romDict.Add('C', 100);
            romDict.Add('D', 500);
            romDict.Add('M', 1000);
            int answer = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i+1 != s.Length)
                {
                    if ((s[i] == 'I' && s[i + 1] == 'V' | s[i + 1] == 'X') | (s[i] == 'X' && s[i + 1] == 'L' | s[i + 1] == 'C') | (s[i] == 'C' && s[i + 1] == 'D' | s[i + 1] == 'M'))
                    {
                        answer = answer - romDict[s[i]];
                    }
                    else
                    {
                        answer = answer + romDict[s[i]];
                    }
                }
                else
                {
                    answer = answer + romDict[s[i]];
                }                           
            }
            return answer;
    }
}