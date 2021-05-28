public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }

            if(dict.ContainsValue(1))
            {
                var ansKey = dict.FirstOrDefault(x => x.Value == 1).Key;
                for(int i = 0; i < s.Length; i++)
                {
                    if(s[i] == ansKey)
                    {
                        return i;
                    }
                }                
            }
            return -1;
    }
}