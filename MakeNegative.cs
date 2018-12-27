using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    // Code?
    if(number * (-1) > number) {
      return number;
    }
    else {
      return number * (-1);
    }
  }
}