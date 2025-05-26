public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 0, majority = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                majority = nums[i];
            }

            count += nums[i] == majority ? 1 : -1;

        }

        return majority;
    }
}