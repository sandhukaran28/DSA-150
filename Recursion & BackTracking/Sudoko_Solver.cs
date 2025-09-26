public class Solution
{

    Dictionary<int, List<int>> rows = new Dictionary<int, List<int>>();
    Dictionary<int, List<int>> cols = new Dictionary<int, List<int>>();
    Dictionary<int, List<int>> boxes = new Dictionary<int, List<int>>();


    public void SolveSudoku(char[][] arr)
    {

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new List<int>();
            cols[i] = new List<int>();
            boxes[i] = new List<int>();
        }

        for (int i = 0; i < arr.Length; i++)
        {

            for (int j = 0; j < arr[i].Length; j++)
            {

                int n = arr[i][j] - '0';
                place(i, j, n);

            }
        }

        sol(arr, 0, 0);
    }

    public bool sol(char[][] arr, int row, int col)
    {

        if (row == 9)
        {
            return true;
        }

        if (col == 9)
        {
            return sol(arr, row + 1, 0);
        }
        if (arr[row][col] != '.')
        {
            return sol(arr, row, col + 1);
        }

        for (int i = 1; i <= 9; i++)
        {
            if (canPlace(row, col, i))
            {
                place(row, col, i);
                arr[row][col] = (char)('0' + i);
                bool isValid = sol(arr, row, col + 1);
                if (isValid)
                {
                    return true;
                }
                unPlace(row, col, i);
                arr[row][col] = '.';
            }
        }

        return false;

    }

    int BoxId(int r, int c) => (r / 3) * 3 + (c / 3);

    bool canPlace(int r, int c, int d)
    {
        return !rows[r].Contains(d)
            && !cols[c].Contains(d)
            && !boxes[BoxId(r, c)].Contains(d);
    }

    public void place(int r, int c, int n)
    {
        rows[r].Add(n);
        cols[c].Add(n);
        int id = BoxId(r, c);
        boxes[id].Add(n);
    }

    public void unPlace(int r, int c, int n)
    {
        rows[r].Remove(n);
        cols[c].Remove(n);
        int id = BoxId(r, c);
        boxes[id].Remove(n);
    }





}