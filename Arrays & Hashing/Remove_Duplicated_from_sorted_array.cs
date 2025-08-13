public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 1;
        }
        int len = nums.Length;
        int write = 1;
        for (int i = 1; i < len; i++)
        {
            if (nums[i] != nums[write - 1])
            {
                nums[write] = nums[i];
                write++;
            }
        }


        return write;
    }
}