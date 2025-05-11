public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length, cols = matrix[0].Length;
        int l = 0 , r = (rows * cols) - 1;
        while(l <= r){
            int mid = (l+r)/2;
            if(matrix[mid/cols][mid % cols] == target){
                return true;
            }
            else if( matrix[mid/cols][mid % cols] > target){
                r = mid -1;
            }
            else{
                l = mid +1;
            }
        }

        return false;
    }
}
