public class Solution {
    public int[] TwoSum(int[] num, int target) {
        int i = 0, j = num.Length - 1;
        while(i < j){
            if(num[i] + num[j] > target){
                j--;
            }
            else if(num[i] + num[j] < target){
                i++;
            }
            else{
                break;
            }
        }

        return [i+1,j+1];
    }
}