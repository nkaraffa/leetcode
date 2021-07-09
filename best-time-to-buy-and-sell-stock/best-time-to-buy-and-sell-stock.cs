public class Solution {
    public int MaxProfit(int[] prices) {
            int max = prices.Max();
            int min = prices.Min();
            int dayB = 0, dayS = 0;
            int buy = max;
            int sell = 0;
            
            //Check if max&min are equal
            if(max == min)
            {
                return 0;
            }

            //Loop through array
            for(int i=0; i<prices.Length; i++)
            {
                if(prices[i] < buy)     //Check if given day's prices are cheaper than yesterday
                {
                    buy = prices[i];
                    dayB = i;
                }
                else
                {
                    sell = Math.Max(sell, prices[i] - buy);     //Choose max value
                }
            }

            return sell;
    }
}