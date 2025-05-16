public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int sum = 0;
      for(int i = 0;i<k; i++){
        sum+= nums[i];
      }  
        double max = (double)sum/k;
      for(int i = k;i< nums.Length;i++ ){
        sum  = sum + nums[i]  - nums[i  - k];
        max = Math.Max(max, (double)sum /k);
      }

      return max;
    }
}