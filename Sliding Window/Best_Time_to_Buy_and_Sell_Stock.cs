public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int profit = 0;
        for(int i = 0;i< prices.Length ;i++){
            if(prices[i] < min){
                min = prices[i];
            }
            else{
                int cProfit = prices[i] - min;
                if(cProfit > profit){
                    profit = cProfit;
                }
            }
        }

        return profit;
    
    }
}
