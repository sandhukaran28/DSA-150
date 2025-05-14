public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] A = nums1.Length > nums2.Length ? nums2 : nums1;
        int[] B = nums1.Length > nums2.Length ? nums1 : nums2;
        int m = A.Length, n = B.Length;
        int l = 0, r = m;
        while (l <= r)
        {
            int i = (l + r) / 2;
            int j = ((m + n + 1) / 2) - i;
            int maxLeftA = i > 0 ? A[i - 1] : -int.MaxValue;
            int minRightA = i < A.Length ? A[i] : int.MaxValue;
            int maxLeftB = j > 0 ? B[j - 1] : -int.MaxValue;
            int minRightB = j < B.Length ? B[j] : int.MaxValue;
            if (maxLeftA < minRightB && minRightA > maxLeftB)
            {
                if ((m + n) % 2 == 0)
                {
                    return ((double)Math.Max(maxLeftA, maxLeftB) + Math.Min(minRightA, minRightB)) / 2;
                }
                else
                {
                    return (double)Math.Max(maxLeftA, maxLeftB);
                }
            }
            else if (maxLeftA > minRightB)
            {
                r = i - 1;
            }
            else
            {
                l = i + 1;
            }

        }

        return 0.0;
    }
}
