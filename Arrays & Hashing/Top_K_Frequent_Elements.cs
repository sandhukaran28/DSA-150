public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] = 0;
            }

            dic[nums[i]]++;
        }


        var bucket = new List<int>[n + 1];

        foreach (var kv in dic)
        {
            int val = kv.Value;
            if (bucket[val] == null)
            {
                bucket[val] = new List<int>();
            }

            bucket[val].Add(kv.Key);
        }

        var res = new List<int>(k);

        for (int i = n; i >= 1 && res.Count < k; i--)
        {
            if (bucket[i] != null)
            {
                foreach (var b in bucket[i])
                {
                    res.Add(b);
                    if (res.Count == k)
                    {
                        break;
                    }
                }
            }
        }

        return res.ToArray();
    }
}