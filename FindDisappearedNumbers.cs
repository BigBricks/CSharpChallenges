public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> found = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            found.Add(i + 1);
        }
        return found.Except(nums).ToList();
    }
}
