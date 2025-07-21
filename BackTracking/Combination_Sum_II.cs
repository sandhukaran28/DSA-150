public class Solution
{
    List<List<int>> ans;
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        ans = new List<List<int>>();
        Array.Sort(candidates);
        sol(candidates, 0, target, new List<int>());
        return ans;
    }

    public void sol(int[] arr, int index, int target, List<int> ls)
    {
        if (target == 0)
        {
            ans.Add(new List<int>(ls));
            return;
        }

        if (index == arr.Length || target < 0)
        {
            return;
        }



        ls.Add(arr[index]);
        sol(arr, index + 1, target - arr[index], ls);
        ls.RemoveAt(ls.Count - 1);
        while (index + 1 < arr.Length && arr[index] == arr[index + 1])
        {
            index++;
        }

        sol(arr, index + 1, target, ls);

    }
}
