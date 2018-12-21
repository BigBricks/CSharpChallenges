using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        int j;
        IEnumerable<int> y = numbers.OrderBy(s => s);
        if (y.ElementAt(0) < y.ElementAt(y.Count() - 1) && (y.ElementAt(0) < y.ElementAt(y.Count() - 2)))
        {
            j = y.ElementAt(0);
        }
        else
        {
            j = y.ElementAt(y.Count() - 1);
        }
        return j;
    }
}