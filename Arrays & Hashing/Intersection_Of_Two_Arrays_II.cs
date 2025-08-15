public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        int[] fre = new int[1001];
        for (int i = 0; i < nums1.Length; i++)
        {
            fre[nums1[i]]++;
        }
        List<int> ls = new List<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            if (fre[nums2[i]] > 0)
            {
                ls.Add(nums2[i]);
                fre[nums2[i]]--;
            }
        }

        return ls.ToArray();
    }
}