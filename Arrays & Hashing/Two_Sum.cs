public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int ,int> hm = new Dictionary<int,int>();
        for(int k = 0;k< nums.Length;k++){
            if(hm.ContainsKey(nums[k])){
                if(2 * nums[k] == target){
                    return [hm[nums[k]], k];
                }
            }
            else{
            hm.Add(nums[k],k);
            }
        }
        for(int i = 0;i< nums.Length;i++){
            if(target - nums[i] != nums[i] && hm.ContainsKey(target - nums[i])){
                return [ i, hm[target-nums[i]]];
            }
        }
        return [];
    }
}