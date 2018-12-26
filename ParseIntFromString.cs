using System;

public class Kata
{
    public static int GetAge(string inputString)
    {
        // return correct age (int). Happy coding :)
        string x = inputString.Substring(0, 1);
        return Convert.ToInt32(x);
    }
}