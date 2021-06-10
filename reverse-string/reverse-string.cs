public class Solution {
    public void ReverseString(char[] s) {
            int i = 0;              //Pointer - front
            int j = s.Length - 1;   //Pointer - end
            char temp;
            char swap;
            while (i<j)
            {
                temp = s[i];        //Holding first value
                swap = s[j];        //Holding last value

                s[i] = swap;        //Replace front value
                s[j] = temp;        //Replace end value

                i++;                //Increment pointer
                j--;                //Decrement pointer
            }

            #region .NET Method
            //s = s.Reverse().ToArray();        //Reverse the array
            #endregion
    }
}