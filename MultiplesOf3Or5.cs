public static class Kata
{
    public static int Solution(int value)
    {
        int count = 0;
        for (int x = 3; x < value; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                count += x;
            }
            else if (x % 3 == 0)
            {
                count += x;
            }
            else if (x % 5 == 0)
            {
                count += x;
            }
        }
        return count;
    }
}