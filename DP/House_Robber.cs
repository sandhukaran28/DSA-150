public class Solution {
    public int Rob(int[] nums) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp,-1);
        return sol(nums,0,dp);
    }

    public int sol(int[] nums, int idx,int[] dp){

        if(idx >= nums.Length){
            return 0;
        }

        if(dp[idx] != -1){
            return dp[idx];
        }

        //rob
        int c1 = sol(nums,idx+2,dp) + nums[idx];

        //don't rob
        int c2  = sol(nums,idx+1,dp);

        return dp[idx] = Math.Max(c1,c2);

    }
}