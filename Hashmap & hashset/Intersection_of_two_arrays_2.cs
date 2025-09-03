public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (!dic.ContainsKey(nums1[i]))
            {
                dic[nums1[i]] = 0;
            }
            dic[nums1[i]]++;
        }

        List<int> ls = new List<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            if (dic.ContainsKey(nums2[i]) && dic[nums2[i]] > 0)
            {
                ls.Add(nums2[i]);
                dic[nums2[i]]--;
            }
        }

        return ls.ToArray();
    }
}