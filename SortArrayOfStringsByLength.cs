public class Kata
{
    public static string[] SortByLength(string[] array)
    {
        System.Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        return array;
    }
}