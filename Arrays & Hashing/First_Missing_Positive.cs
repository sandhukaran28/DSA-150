public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        //normalise
        int n = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = n + 1;
            }
        }

        //mark -ve

        for (int i = 0; i < n; i++)
        {
            int v = Math.Abs(nums[i]);
            if (v >= 1 && v <= n)
            {
                int idx = v - 1;
                if (nums[idx] >= 0)
                {
                    nums[idx] = -nums[idx];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (nums[i] >= 0)
            {
                return i + 1;
            }
        }

        return n + 1;
    }
}