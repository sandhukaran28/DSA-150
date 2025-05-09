public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0, r = matrix.Length - 1;
        while(l <= r){
            int mid = (l+r)/2;
            if(target >= matrix[mid][0] && target <= matrix[mid][matrix[mid].Length -1]){
                int l_col = 0 , r_col  = matrix[mid].Length -1;
                while(l_col <= r_col){
                    int mid_col = (l_col + r_col)/2;
                    if(target == matrix[mid][mid_col]){
                        return true;
                    }
                    else if(target < matrix[mid][mid_col]){
                        r_col = mid_col -1;
                    }
                    else{
                        l_col = mid_col + 1;
                    }
                }
                break;
            }
            else if(target < matrix[mid][0]){
                r = mid - 1;
            }
            else{
                l = mid +1;
            }
        }

        return false;
    }
}
