public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    bool res = sol(board, word, 0, i, j);
                    if (res == true)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public bool sol(char[][] arr, string word, int index, int i, int j)
    {

        if (i >= arr.Length || j >= arr[0].Length || i < 0 || j < 0 || arr[i][j] == '#')
        {
            return false;
        }

        if (arr[i][j] == word[index])
        {
            index++;
        }
        else
        {
            return false;
        }
        if (index == word.Length)
        {
            return true;
        }
        char c = arr[i][j];
        arr[i][j] = '#';
        bool s1 = sol(arr, word, index, i + 1, j);
        bool s2 = sol(arr, word, index, i - 1, j);
        bool s3 = sol(arr, word, index, i, j + 1);
        bool s4 = sol(arr, word, index, i, j - 1);
        arr[i][j] = c;
        return s1 || s2 || s3 || s4;

    }
}
