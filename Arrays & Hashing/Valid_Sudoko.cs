public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int,HashSet<char>> rows = new Dictionary<int,HashSet<char>>();
        Dictionary<int,HashSet<char>> cols = new Dictionary<int,HashSet<char>>();
        Dictionary<int,HashSet<char>> boxes = new Dictionary<int,HashSet<char>>();

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                char num = board[i][j];

                // Skip empty cells
                if (num == '.') continue;

                int boxIndex = (i / 3) * 3 + (j / 3); 

                // Validate row
                if (!rows.ContainsKey(i))
                    rows[i] = new HashSet<char>();
                if (!rows[i].Add(num)) return false;

                // Validate column
                if (!cols.ContainsKey(j))
                    cols[j] = new HashSet<char>();
                if (!cols[j].Add(num)) return false;

                // Validate 3x3 box
                if (!boxes.ContainsKey(boxIndex))
                    boxes[boxIndex] = new HashSet<char>();
                if (!boxes[boxIndex].Add(num)) return false;
            }
        }
        return true;
    }
}