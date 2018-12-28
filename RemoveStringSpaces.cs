namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        //Code it!
        var x = input.Split(" ");
        return string.Join("", x);
    }  
  }
}