public class Solution {
    public void MoveZeroes(int[] nums) {
      int n = nums.Length;
        int count = 0;
        int x;
        for(int i = 0; i < n; i++) {
            if(nums[i] != 0) {
               x = nums[count];
               nums[count] = nums[i];
                nums[i] = x;
                count++;
            }
          
        }
    }
}