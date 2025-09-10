public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int l = 0, sum = 0, ans = int.MaxValue;
        for (int r = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            while (sum >= target && l <= r)
            {
                ans = Math.Min(ans, r - l + 1);
                sum -= nums[l++];
            }
        }

        return ans == int.MaxValue ? 0 : ans;
    }
}