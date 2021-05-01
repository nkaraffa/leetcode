public class Solution {
    public bool CheckIfPangram(string sentence) {
        List<char> alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < sentence.Length; i++)       //Check given string for all alphabet letters
            {
               char charConvert = sentence[i];
               if(alphabet.Contains(charConvert))
                {
                    alphabet.Remove(charConvert);           //If letter exists in string, then remove from 'char' list
                }
            }

            if(alphabet.Count == 0)         //Check for pangram by alphabet letter count in 'alphabet'
            {
                return true;
            }
            else
            {
                return false;
            }   
    }
}