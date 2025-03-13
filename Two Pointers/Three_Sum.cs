public class Solution
{
    public IList<IList<int>> ThreeSum(int[] arr)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        Array.Sort(arr);
        for (int i = 0; i < arr.Length - 2; i++)
        {
            if (i > 0 && arr[i] == arr[i - 1])
            {
                continue;
            }
            int l = i + 1;
            int r = arr.Length - 1;
            while (l < r)
            {
                int sum = arr[i] + arr[l] + arr[r];
                if (sum == 0)
                {
                    ans.Add(new List<int> { arr[i], arr[l], arr[r] });

                    while (l < r && arr[l] == arr[l + 1])
                    {
                        l++;
                    }
                    while (l < r && arr[r] == arr[r - 1])
                    {
                        r--;
                    }
                    l++;
                    r--;

                }
                else if (sum < 0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }


        }
        return ans;
    }
}