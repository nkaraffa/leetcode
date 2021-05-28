public class Solution {
    public bool IsHappy(int n) {
        while (true)
            {
                if (n == 1 || n == 7 || n == 10 || n == 100)    //Values that turn 'Happy'
                {
                    return true;
                }
                else if(n < 10)     //Others values <10, not 'happy'
                {
                    return false;
                }

                int total = 0;                      //Clear total value
                while (n > 0)
                {
                    total += (n % 10) * (n % 10);   //Retrieve each digit and square value
                    n /= 10;                        //Remove digit
                }
                n = total;                          //convert n into total value
            }
    }
}