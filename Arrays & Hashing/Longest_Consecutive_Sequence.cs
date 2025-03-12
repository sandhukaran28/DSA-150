public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> hs = new HashSet<int>();

       for(int i = 0;i<nums.Length;i++){
        hs.Add(nums[i]);
       } 

       int max = 0;
       for(int i = 0;i< nums.Length;i++){
        if(!hs.Contains(nums[i])){
            continue;
        }
        int count = 0;
        if(!hs.Contains(nums[i] - 1) && nums.Length > 0){
            int ele = nums[i];
            count++;
            while(hs.Contains(ele +1)){
                hs.Remove(ele);
                ele++;
                count++;
            }
        }
        if(count > max){
            max = count;
        }
       }
       return max;
    }
}