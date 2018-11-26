public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
    int bob = 1000;
      for(int i = 0; i < args.Length; i++) 
      {
        if(bob > args[i]) 
        {
          bob = args[i];
        }
      }
      return bob;
    }
}