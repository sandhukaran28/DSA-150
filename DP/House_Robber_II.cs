public class Solution {
    public int Rob(int[] nums) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp,-1);

        int[] dp2 = new int[nums.Length];
        Array.Fill(dp2,-1);

        return Math.Max(sol(nums,2,true,dp)+nums[0],sol(nums,1,false,dp2)); 
    }

    public int sol(int[] nums,int idx, bool first,int[] dp){

        if(idx >= nums.Length){
            return 0;
        }

        if(idx == nums.Length -1 && first == true){
            return 0;
        }

        if(dp[idx] != -1){
            return dp[idx];
        }

        return dp[idx] = Math.Max((sol(nums,idx+2,first,dp)+nums[idx]),sol(nums,idx+1,first,dp));
    }
}