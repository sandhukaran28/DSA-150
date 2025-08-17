public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int prefix = 0, count = 0;
        dic.Add(0, 1);

        for (int i = 0; i < nums.Length; i++)
        {
            prefix += nums[i];
            if (dic.ContainsKey(prefix - k))
            {
                count += dic[prefix - k];
            }

            if (dic.ContainsKey(prefix))
            {
                dic[prefix]++;
            }
            else
            {
                dic[prefix] = 1;
            }
        }

        return count;
    }
}