public class Solution {
    public int SmallestRangeI(int[] A, int K) {
        int x = A.Length;
        int i = A.Max() - A.Min();
        if(i<= 2*K) return 0;
        return i-2*K;
    }
}