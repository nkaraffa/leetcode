public class Solution {
    public int SearchInsert(int[] nums, int target) {
        //Edge Cases: Less than OR greater than array values
            if (nums[0] > target)
            {
                return 0;
            }
            else if (nums[nums.Length - 1] < target)
            {
                return nums.Length;
            }

            //Iterate threw array values till match or gap found
            for (int i =0; i<nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    return i;
                }

                if(nums[i] > target && nums[i-1] < target && i != 0)
                {
                    return i;
                }
            }

            return 0;
    }
}