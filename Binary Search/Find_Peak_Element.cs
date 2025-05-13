public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0, r = nums.Length -1;
        int length = nums.Length;
        while(l <=r ){
            int mid = (l+r)/2;
            if(((mid > 0 && nums[mid] > nums[mid -1]) || mid == 0) &&
             (((mid <  length -1  && nums[mid] > nums[mid + 1]) || mid ==  length -1))){
                return mid;
             }
             else if(mid > 0 && mid < length - 1 ){
                    if(nums[mid - 1 ] > nums[mid + 1]){
                        r = mid -1;
                    }
                    else{
                        l = mid+1;
                    }
             }
             else if(mid == 0){
                l = mid+1;
             }
             else{
                r = mid -1;
             }
        }
        return l;   
    }
}