public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0], price = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] >= min)
            {
                price = Math.Max(price, prices[i] - min);
            }
            else
            {
                min = prices[i];
            }
        }
        return price;
    }
}
