public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int l = 0, r = 0, curr = 0, ans = int.MinValue;
        while (r < nums.Length)
        {
            curr += nums[r++];
            ans = Math.Max(ans, curr);
            Console.WriteLine(curr);
            while (curr < 0)
            {
                curr -= nums[l++];
            }
        }

        return ans;
    }
}


public class Solution {
    public int MaxSubArray(int[] nums) {
        int curr = nums[0], ans = nums[0];

        for(int i = 1;i< nums.Length;i++){
            curr = Math.Max(nums[i], curr + nums[i]);
            ans = Math.Max(ans, curr);
        }

        return ans;
    }
}