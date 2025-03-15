public class Solution
{
    public int Trap(int[] arr)
    {
        int l = 0, r = arr.Length - 1;
        int l_max = arr[l], r_max = arr[r];
        int sum = 0;

        while (l < r)
        {
            if (l_max < r_max)
            {
                l++;
                l_max = Math.Max(l_max, arr[l]);
                int current = Math.Min(l_max, r_max) - arr[l];
                if (current > 0)
                {
                    sum += current;
                }
            }
            else
            {
                r--;
                r_max = Math.Max(r_max, arr[r]);
                int current = Math.Min(l_max, r_max) - arr[r];
                if (current > 0)
                {
                    sum += current;
                }

            }
        }

        return sum;
    }
}