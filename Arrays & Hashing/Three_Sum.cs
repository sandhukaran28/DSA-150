public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> ans = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {

            int l = i + 1, r = nums.Length - 1;

            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum == 0)
                {
                    ans.Add(new List<int>() { nums[i], nums[l], nums[r] });

                    while (l < r && nums[l] == nums[l + 1])
                    {
                        l++;
                    }
                    while (l < r && nums[r] == nums[r - 1])
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

            while (i < nums.Length - 2 && nums[i] == nums[i + 1])
            {
                i++;
            }
        }

        return ans;
    }
}