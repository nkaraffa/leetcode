public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
        int n = chalk.Length;       // # of students
            int cIndex = 0;             // Current student and chalk usage
            long sum = 0;
            foreach(int i in chalk)
            {
                sum += i;
            }
            long kLeft = (long)k % (long)sum;       // Sum chalk on-hand and determine how much extra is needed.

            while (0 <= kLeft)
            {
                if (kLeft < chalk[cIndex])      //If chalk uasge is greater than chalk then end
                {
                    return cIndex;          //Student that will replace chalk
                }
                kLeft -= chalk[cIndex];      //Decrement chalk
                cIndex++;
                if (cIndex >= n)         //Determine how much chalk to use; If chalk limit reached, revert to 0 index
                {
                    cIndex = 0;
                }
            }
            
            return 0;
    }
}