public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int l = 0, r = 0, ans = int.MaxValue, sum = 0;
        while (r < nums.Length)
        {
            sum += nums[r++];
            while (sum >= target)
            {
                ans = Math.Min(ans, r - l);
                sum -= nums[l++];

            }
        }

        return ans == int.MaxValue ? 0 : ans;

    }
}