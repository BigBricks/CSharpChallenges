public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        for(int i = 1; i < A.Length; i++) {
            if(A[i-1] < A[i] && A[i] > A[i+1]) {
                return i;
            }
        }
        return -1;
    }
}