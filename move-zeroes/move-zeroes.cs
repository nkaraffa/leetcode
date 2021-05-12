public class Solution {
    public void MoveZeroes(int[] nums) {
        /*Algorthim
             * Constraint:  0 <= nums.length <= 10^4; -2^31 <= nums[i] <= -2^31
             * 1. Assess if '0' exists in the array
             * 2. Select the index in array -> swap next non-zero index with previous non-zero index
             * 3. Use nested loops to check current index against other entries (memory-intensive)
             * 4. Modify the given array using 'ref'
            */

            if (nums.Length == 0)
            {
                Console.WriteLine("Done");       //Array size 0
            }
            else if (!nums.Contains(0))
            {
                Console.WriteLine("Done");      //Return "Done", b/c array doesn't contain '0'
            }
            else
            {
                int temp;
                int j = 0;
                for(int i=0; i<nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                        j++;

                    }                  
                }
            }
    }
}