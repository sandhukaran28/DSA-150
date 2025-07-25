public class Solution
{
    HashSet<int> cols;
    HashSet<int> diag1;
    HashSet<int> diag2;
    List<List<string>> ans;
    public List<List<string>> SolveNQueens(int n)
    {
        cols = new HashSet<int>();
        diag1 = new HashSet<int>();
        diag2 = new HashSet<int>();
        ans = new List<List<string>>();
        sol(n, 0, new List<string>());
        return ans;
    }

    public void sol(int n, int row, List<string> ls)
    {

        if (row == n)
        {
            ans.Add(new List<string>(ls));
            return;
        }
        string st = "";
        for (int col = 0; col < n; col++)
        {
            if (!cols.Contains(col) && !diag1.Contains(row + col) && !diag2.Contains(row - col))
            {
                string curr = st;
                curr = curr + 'Q';
                for (int i = col + 1; i < n; i++)
                {
                    curr = curr + '.';
                }
                ls.Add(curr);
                cols.Add(col);
                diag1.Add(row + col);
                diag2.Add(row - col);

                sol(n, row + 1, ls);

                ls.RemoveAt(ls.Count - 1);
                cols.Remove(col);
                diag1.Remove(row + col);
                diag2.Remove(row - col);
            }
            st = st + '.';
        }
    }
}
