public class Solution
{
    public int FindMin(int[] nums)
    {
        int min = int.MaxValue;
        int l = 0, r = nums.Length - 1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            min = Math.Min(min, nums[mid]);

            if (nums[r] < nums[l] && nums[mid] >= nums[l])
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
            Console.WriteLine(l + " " + r);
        }

        return min;
    }
}