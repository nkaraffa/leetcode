public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> numCheck = new Dictionary<int, int>();
            foreach(int i in nums)
            {
                if (!numCheck.ContainsKey(i))
                {
                    numCheck.Add(i, 1);     //Checks if element is in dictionary
                }
                else
                {
                    numCheck[i] += 1;       //Increases dictionary key-value by 1 for occurance
                }
            }

            var answer = numCheck.FirstOrDefault(x => x.Value == numCheck.Values.Min()).Key;
            return answer;
    }
}