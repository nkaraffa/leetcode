public class Solution {
    public int Reverse(int x) 
    {
            int answer = 1;
            bool posCheck = x >= 0;              //Checks for int sign

            if (Int32.MaxValue > x  && Int32.MinValue < x)
            {                
                x = Math.Abs(x);                    //Absolute value to speed conversion
                string rev = Convert.ToString(x);
                string temp = "";

                for (int i = rev.Length - 1; i >= 0; i--)
                {
                    temp = temp + rev[i];
                }

                if (Int32.MaxValue > Int64.Parse(temp))   //Check problem condition for max int32 value   
                {
                    if (posCheck)                       //Replace int sign from the beginning
                    {
                        answer = int.Parse(temp);
                    }
                    else
                    {
                        answer = -1 * int.Parse(temp);
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

            return answer;
    }
}