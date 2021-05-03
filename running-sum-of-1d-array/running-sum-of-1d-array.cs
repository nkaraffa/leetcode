public class Solution {
    public int[] RunningSum(int[] nums) {
        /*Algorthim
             * 1. Create For loop for array & output array 'sum'
             * 2. if i=0 then nums[i]
             * 3. else then nums[i-1 + i]
             * 4. save values in sum, then return sum
            */
            int[] sum = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    sum[i] = nums[i];
                }
                else
                {
                    sum[i] = sum[i-1] + nums[i];
                }
            }
            return sum;
    }
}