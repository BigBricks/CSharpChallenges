public class Solution {
    public bool IsMonotonic(int[] A) {
        return IsMonotonicDecreasing(A) || IsMonotonicIncreasing(A);
    }
    public bool IsMonotonicDecreasing(int[] A) {
       for(int i = 0; i < A.Length-1; i++) {
           if(A[i] < A[i+1]) {
               return false;
           }
       } 
        return true;
    }
    public bool IsMonotonicIncreasing(int[] A) {
        for(int i = 0; i < A.Length-1; i++) {
           if(A[i] > A[i+1]) {
               return false;
           }
       } 
        return true;
    }
}