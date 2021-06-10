public class Solution {
    public int MissingNumber(int[] nums) {
            int total = nums.Length;
            int misNum = (total * (total + 1)) / 2;     //Gaussian Formula for Sum of #s

            for(int i=0; i< nums.Length; i++)
            {
                misNum -= nums[i];          //Subtract entries from sum to find missing #
            }
            return misNum;

            #region Time Intensive
            //int misNum = 0;     //return value
            //Array.Sort(nums);   //sort the array to make finding missing num easier
            //if (!(nums.Contains(nums.Length)))
            //{
            //    return misNum = nums.Length;
            //}
            //else if(!(nums.Contains(0)))
            //{
            //    return 0;
            //}

            //for(int i=0; i<nums.Length; i++)
            //{
            //    if(!nums.Contains(i))    //Check sorted array index against "true" value
            //    {
            //        misNum = i;     //Set var = i, if current index doesn't match true value
            //    }
            //}
            //return misNum;
            #endregion
    }
}