public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0)
            {
                return 0;       //Array size 0
            }

            int oddAnswer = 0;
            int i = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        i++;
                        oddAnswer++;
                        nums[i] = nums[j];
                    }
                }
            
            return oddAnswer + 1;       //values changed plus initial value


            #region Alternate Answer
            //int answer = nums.Distinct().Count();
            //nums = nums.Distinct().ToArray();
            //return answer;
            #endregion

            #region Alternate Answer 2
            //int altAnswer = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            nums[j] = (-11 ^ 4);
            //        }
            //    }
            //}

            //nums = nums.Except(new int[] { (-11 ^ 4) }).ToArray();
            //altAnswer = nums.Length;
            //return altAnswer;
            #endregion
    }
}