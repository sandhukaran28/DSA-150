public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        if (nums.Length == 1)
        {
            return;
        }
        int write = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (i != write)
                {
                    int temp = nums[i];
                    nums[i] = nums[write];
                    nums[write] = temp;

                }
                write++;
            }
        }
    }
}