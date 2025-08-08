public class Solution
{
    public int MaxProduct(int[] nums)
    {
        return sol(nums, 0, 1);
    }

    public int sol(int[] nums, int index, int curr)
    {
        if (index >= nums.Length)
        {
            return -100000000;
        }

        curr = curr * nums[index];
        int c1 = sol(nums, index + 1, curr);
        int c2 = sol(nums, index + 1, 1);

        return Math.Max(curr, Math.Max(c1, c2));
    }
}
