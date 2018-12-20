public class Solution
{
    public string ReverseWords(string s)
    {
        var r = s.Split(" ").Select(word => new String(word.Reverse().ToArray()));
        return string.Join(" ", r);
    }
}