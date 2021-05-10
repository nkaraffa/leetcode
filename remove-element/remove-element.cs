public class Solution {
    public int RemoveElement(int[] nums, int val) {
        /*Algorthim
             * Constraint:  0 <= nums.length <= 100; 0 <= nums[i] <= 50; 0 <= val <= 100
             * 1. Assess if 'val' exists in the array
             * 2. Select an index -> check the rest of the array and remove 'val'
             * 3. Use nested loops to check current index against other entries (memory-intensive)
             * 4. Return nums.Length as result
            */

            if (nums.Length == 0)
            {
                return 0;       //Array size 0
            }
            else if (! nums.Contains(val))
            {
                return nums.Length;     //Return current array length, b/c array doesn't contain 'val'
            }

            int arrayLength = nums.Length;
            for (int i=0; i < nums.Length; i++)
            {
                if(nums[i] == val)
                {
                    nums[i] = 101;
                    --arrayLength;
                }
            }

            Array.Sort(nums);
            return arrayLength;
    }
}