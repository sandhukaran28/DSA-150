public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<string, HashSet<char>> rows = new Dictionary<string, HashSet<char>>();
        Dictionary<string, HashSet<char>> cols = new Dictionary<string, HashSet<char>>();
        Dictionary<string, HashSet<char>> box = new Dictionary<string, HashSet<char>>();

        for (int i = 0; i < 9; i++)
        {

            for (int j = 0; j < 9; j++)
            {

                char num = board[i][j];
                if (num == '.')
                {
                    continue;
                }
                //row 
                string rKey = i.ToString();

                if (!rows.ContainsKey(rKey))
                {
                    rows[rKey] = new HashSet<char>();
                }

                if (rows[rKey].Contains(num))
                {
                    return false;
                }
                rows[rKey].Add(num);

                //col
                string cKey = j.ToString();

                if (!cols.ContainsKey(cKey))
                {
                    cols[cKey] = new HashSet<char>();
                }

                if (cols[cKey].Contains(num))
                {
                    return false;
                }
                cols[cKey].Add(num);
                //box
                string bKey = (i / 3).ToString() + (j / 3).ToString();

                if (!box.ContainsKey(bKey))
                {
                    box[bKey] = new HashSet<char>();
                }

                if (box[bKey].Contains(num))
                {
                    return false;
                }
                box[bKey].Add(num);
            }
        }

        return true;
    }
}