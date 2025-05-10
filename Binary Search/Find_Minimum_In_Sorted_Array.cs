public class Solution {
    public int FindMin(int[] nums) {
        int  l =0, r = nums.Length -1;
        while(l < r){
            int mid = (l+r)/2;
            if(nums[r] < nums[mid]){
                l = mid + 1;
            }
            else{
            r = mid;
            }
        }

        return nums[l];
    }
}
