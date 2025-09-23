public class Solution
{
    IList<IList<int>> ans;
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        ans = new List<IList<int>>();
        sol(candidates, 0, target, new List<int>());
        return ans;
    }

    public void sol(int[] arr, int index, int target, List<int> curr)
    {

        if (target == 0)
        {
            if (!ans.Contains(curr))
            {
                ans.Add(new List<int>(curr));
            }

            return;
        }
        if (target < 0 || index == arr.Length)
        {
            return;
        }
        //subtract current
        //1 stay on same
        curr.Add(arr[index]);
        sol(arr, index, target - arr[index], curr);

        curr.RemoveAt(curr.Count - 1);
        //skip current
        sol(arr, index + 1, target, curr);
    }
}