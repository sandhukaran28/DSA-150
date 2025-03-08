public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];

        int prefix = 1;
        Array.Fill(res,1);

        for(int i = 1;i < res.Length;i++){
            prefix = prefix * nums[i -1 ];
            res[i] = prefix;
        }

        int suffix = 1;

        for(int i = res.Length - 2 ; i>=0;i--){
            suffix = suffix * nums[i + 1];
            res[i] = res[i] * suffix;
        }   

        return res;
    }
}