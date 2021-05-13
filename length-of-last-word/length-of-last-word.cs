public class Solution {
    public int LengthOfLastWord(string s) {
        if(s == "" || s == " ")
            {
                return 0;
            }
            else
            {
                int lastSpace = s.LastIndexOf(" ");
                string temp = "";
                if (lastSpace == s.Length-1)
                {
                    s = s.TrimEnd(' ');
                    lastSpace = s.LastIndexOf(" ");
                }
                for(int i = lastSpace+1; i<s.Length; i++)
                {
                    temp = temp + s[i];
                }
                return temp.Length;
            }
    }
}