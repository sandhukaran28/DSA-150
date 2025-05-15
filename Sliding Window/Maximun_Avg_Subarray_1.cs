public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int l = 0;
        double total = 0;
        double max = -1000000;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i - l + 1 <= k)
            {
                total += nums[i];
            }
            else
            {
                total -= nums[l++];
                total += nums[i];
            }

            if (i - l + 1 == k)
            {
                max = Math.Max(max, total / k);
            }
        }
        return max;
    }
}