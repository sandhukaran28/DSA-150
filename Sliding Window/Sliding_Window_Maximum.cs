public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return nums;
        }
        List<int> ans = new List<int>();
        var deque = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }
            deque.AddLast(i);

            if (i >= k - 1)
            {
                ans.Add(nums[deque.First.Value]);
            }
        }

        return ans.ToArray();

    }
}