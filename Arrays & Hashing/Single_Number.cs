public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int n = nums[0];
        if (nums.Length == 0)
        {
            return n;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            n = n ^ nums[i];
        }

        return n;
    }
}