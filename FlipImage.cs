public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        int[][] x = new int[A.Length][];
        for(int i = 0; i < A.Length; i++) {
            x[i] = new int[A[i].Length];
            for(int j = 0; j < A[i].Length; j++) {
                x[i][A[i].Length-j-1] = A[i][j] == 0 ? 1 : 0;
            }
        }
        return x;
    }
}