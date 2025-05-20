public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int ele = -1, max = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] = 0;
            }

            dic[nums[i]]++;
            if (dic[nums[i]] > max)
            {
                max = dic[nums[i]];
                ele = nums[i];
            }
        }

        return ele;
    }
}