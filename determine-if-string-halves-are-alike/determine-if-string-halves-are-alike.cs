public class Solution {
    public bool HalvesAreAlike(string s) {
        s = s.ToLower();        //converts User-input to lowercase
            
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('a', 0);
            dict.Add('e', 0);
            dict.Add('i', 0);
            dict.Add('o', 0);
            dict.Add('u', 0);

            string a = "";      //string-halves
            string b = "";
            int count1 = 0;     //vowel counters
            int count2 = 0;

            for (int i =0; i<s.Length; i++)     //split the string 's'
            {
                if(i < s.Length/2)
                {
                    a = a + s[i];
                }
                else
                {
                    b = b + s[i];
                }
            }

            for(int j=0; j < a.Length; j++)     //Count the vowels 
            {
                if (dict.ContainsKey(a[j]))
                {
                    count1++;
                }

                if (dict.ContainsKey(b[j]))
                {
                    count2++;
                }
                
            }

            if (count1 == count2)       //Return output
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}