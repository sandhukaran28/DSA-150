public class Solution
{
    public int MaxArea(int[] arr)
    {
        int i = 0;
        int j = arr.Length - 1;
        int max = 0;

        while (i < j)
        {
            int current = Math.Min(arr[i], arr[j]) * (j - i);
            if (current > max)
            {
                max = current;
            }

            if (i < j && arr[i] < arr[j])
            {
                i++;
            }
            else if (i < j && arr[i] > arr[j])
            {
                j--;
            }
            else
            {
                i++;
                j--;
            }
        }

        return max;
    }
}