public class Solution {
    public string ReverseStr(string s, int k) {
        if (s == null || k < 1)
            {
                return s;
            }
            else if(s.Length < k)
            {
                var rev = s.Reverse();
                return string.Concat(rev);
            }

                int i = 0;          //Pointer - front
            int j = s.Length;   //Pointer - end
            char temp;
            char swap;
            char[] chars = s.ToCharArray();     //Convert string to char array

            int limit = k;
            int pt = k - 1;
            while (i < j)
            {
                for(int q = i; q<pt; q++)
                {
                    temp = s[q];            //Holding first value
                    swap = s[pt];           //Holding last value

                    chars[q] = swap;        //Replace front value
                    chars[pt] = temp;       //Replace end value
                    
                    pt--;
                }              
                
                i += k+k;                //Increment pointer
                limit += k + k;          //Increment pointer

                if(limit - 1 < s.Length - 1)    //Reset for loop pointer
                {
                    pt = limit - 1;          
                }
                else
                {
                    pt = s.Length - 1;
                }                
            }

            return new string(chars);       //Convert char array to string
    }
}