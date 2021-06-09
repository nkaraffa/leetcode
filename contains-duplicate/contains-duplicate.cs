public class Solution {
    public bool ContainsDuplicate(int[] nums) {
      //Check if # of distinct elements matches nums.Count
            if(nums.Distinct().Count() == nums.Count())
            {
                return false;   //Every int is unique
            }
            else
            {
                return true;    //At least on duplicate exists
            }  
    }
}