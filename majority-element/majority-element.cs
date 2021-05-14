public class Solution {
    public int MajorityElement(int[] nums) {
            ///Create Dictionary for num (or For loop)
            //Create for loop for array values -> add unique value to dictionary
            //Check dictionary keys against (n/2) -> if key > (n/2), then answer key.Count
            if (nums.Length == 1)
            {
                return int.Parse(nums.GetValue(0).ToString());
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if( !dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]] += 1;
                }
            }

            var answerKey = dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Key;

            return answerKey;
    }
}