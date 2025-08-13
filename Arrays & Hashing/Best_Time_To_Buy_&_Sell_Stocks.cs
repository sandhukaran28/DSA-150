public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 1)
        {
            return 0;
        }
        int min = prices[0], max = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] - min < 0)
            {
                min = prices[i];
            }
            else if (prices[i] - min > max)
            {
                max = prices[i] - min;
            }
        }

        return max;
    }
}