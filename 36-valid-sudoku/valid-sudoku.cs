public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var boxes = new Dictionary<int, HashSet<char>>();

        for(int i = 0; i < 9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                char num = board[i][j];
                if(num == '.') continue;

                int boxIndex = (i / 3) * 3 + (j / 3);

                if(rows[i].Contains(num) || cols[j].Contains(num) || boxes[boxIndex].Contains(num)){
                    return false;
                }
                rows[i].Add(num);
                cols[j].Add(num);
                boxes[boxIndex].Add(num);
            }
           

        }
        return true;

    }
}