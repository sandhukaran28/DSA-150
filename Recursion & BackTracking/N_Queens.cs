public class Solution
{
    HashSet<int> cols = new HashSet<int>();
    HashSet<int> d1 = new HashSet<int>();
    HashSet<int> d2 = new HashSet<int>();
    IList<IList<string>> ans = new List<IList<string>>();

    public IList<IList<string>> SolveNQueens(int n)
    {

        sol(0, n, new List<string>());
        return ans;
    }

    public void sol(int row, int n, IList<string> ls)
    {

        if (row == n)
        {
            ans.Add(new List<string>(ls));
            return;
        }

        for (int i = 0; i < n; i++)
        {
            if (valid(row, i))
            {
                cols.Add(i);
                d1.Add(row + i);
                d2.Add(row - i);
                //string building
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    sb.Append('.');
                }
                sb.Append('Q');
                for (int j = i + 1; j < n; j++)
                {
                    sb.Append('.');
                }

                ls.Add(sb.ToString());
                sol(row + 1, n, ls);
                ls.RemoveAt(ls.Count - 1);
                cols.Remove(i);
                d1.Remove(row + i);
                d2.Remove(row - i);
            }
        }
    }

    public bool valid(int r, int c)
    {
        if (!cols.Contains(c) && !d1.Contains(r + c) && !d2.Contains(r - c))
        {
            return true;
        }
        return false;
    }
}
