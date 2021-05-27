public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] answer = new int[2];

            int i = 0;                  //Two pointers to search the array
            int j = numbers.Length-1;
            while(i < j)
            {
                if (target == numbers[i] + numbers[j])
                {
                    answer[0] = i + 1;
                    answer[1] = j + 1;
                    return answer;
                }
                
                if(target < numbers[i] + numbers[j])        //Since the array is sorted, if too large (decrease j), else (increase i) 
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return answer;

            #region Intensive Method O(n)
            // One pointer that searches the array
            //for (int k = 0; k < numbers.Length; k++)
            //{
            //    if (numbers.Contains(target - numbers[k]))
            //    {
            //        answer[0] = k + 1;
            //        answer[1] = Array.LastIndexOf(numbers, target - numbers[k]) + 1;
            //        return answer;
            //    }
            //}
            #endregion

            #region intensive method O(n^2)
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (target == numbers[i] + numbers[j])
            //        {
            //            answer[0] = i + 1;
            //            answer[1] = j + 1;
            //            break;
            //        }
            //    }
            //}
            #endregion

            return answer;
    }
}