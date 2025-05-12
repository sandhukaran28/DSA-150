public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int l = 0, r = arr.Length -1;
        int max = 0;
        while(l <= r){
            int mid = (l+r)/2;
            if(arr[mid] > arr[max]){
                max = mid;
            }
            if(arr[mid] < arr[mid+1]){
                l = mid +1;
            }
            else{
                r = mid -1;
            }
        }

        return max;
    }
}