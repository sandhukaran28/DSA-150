public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                bool ans = sol(board, word, i, j, 0);
                if (ans)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool sol(char[][] board, string word, int i, int j, int index)
    {

        if (index == word.Length)
        {
            return true;
        }

        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)
        {
            return false;
        }

        if (board[i][j] == word[index])
        {
            board[i][j] = '.';
            bool c1 = sol(board, word, i, j + 1, index + 1);
            bool c2 = sol(board, word, i, j - 1, index + 1);
            bool c3 = sol(board, word, i + 1, j, index + 1);
            bool c4 = sol(board, word, i - 1, j, index + 1);
            board[i][j] = word[index];

            return c1 || c2 || c3 || c4;
        }

        return false;
    }
}