public class Solution
{
    public int CountPartitions(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }


        return sum % 2 == 0 ? nums.Length - 1 : 0;
    }
}