public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> f = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            f.Add(i + 1);
        }
        return f.Except(nums).ToList();
    }
}