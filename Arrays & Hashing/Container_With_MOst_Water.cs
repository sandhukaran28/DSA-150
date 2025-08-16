public class Solution
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        int l = 0, r = height.Length - 1;

        while (l < r)
        {
            int left = height[l];
            int right = height[r];

            max = Math.Max(max, Math.Min(left, right) * (r - l));
            if (left < right)
            {
                l++;
            }
            else
            {
                r--;
            }
        }

        return max;
    }
}