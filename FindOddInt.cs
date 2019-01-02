using System;
using System.Linq;
namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            var answer = seq.GroupBy(x => x).Where(x => x.Count() % 2 != 0).Select(x => x.First()).FirstOrDefault();
            return answer;
        }

    }
}