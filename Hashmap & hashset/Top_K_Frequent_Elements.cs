public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        List<int> ans = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] = 0;
            }

            dic[nums[i]]++;
        }

        var fre = new List<int>[nums.Length + 1];

        foreach (var kv in dic)
        {
            int val = kv.Value;
            if (fre[val] == null)
            {
                fre[val] = new List<int>();
            }
            fre[val].Add(kv.Key);
        }

        for (int i = nums.Length; i >= 0; i--)
        {

            if (fre[i] == null)
            {
                continue;
            }

            foreach (var item in fre[i])
            {
                if (k > 0)
                {
                    ans.Add(item);
                    k--;
                }
                else
                {
                    break;
                }
            }

            if (k == 0)
            {
                break;
            }
        }

        return ans.ToArray();
    }
}