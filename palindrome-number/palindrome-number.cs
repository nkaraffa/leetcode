public class Solution {
    public bool IsPalindrome(int x) {
        /*Algorthim
             * 1. Convert int 'x' to string
             * 2. Create temp variable (type: string)
             * 3. Reverse string variable; store value in temp
             * 4. compare strings for Palindrome; return bool result
            */
            string orig = x.ToString();
            string revString = "";
            for(int i= orig.Length-1; 0<=i; i--)
            {
                revString += orig[i];
            }

            if(revString == orig)
            {
                return true;
            }
            else
            {
                return false;
            } 
    }
}