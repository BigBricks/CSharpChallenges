public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        //Code here...
        System.Array.Sort(numbers);
        int result = numbers[0] + numbers[1];
        return result;
    }
}