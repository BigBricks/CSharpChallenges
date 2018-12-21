using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    // Return a new list with its elements in reverse order compared to the input list
    // Do not mutate the original list!
    List<int> we = new List<int>();
    foreach(int x in list) {
    we.Add(x);}
    we.Reverse();
    return we;
  }
}