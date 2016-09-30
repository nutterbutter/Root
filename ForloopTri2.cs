using System;
			
public class ForloopTri2
{
  public static void Main()
  {
    int row, star;
    for(row = 0; row < 3; row++)
    {
      for(star = 0; star < row +1; star++)
      {
        Console.Out.Write("*");
      }
      for(int space = 0; space < 3- row; space++)
      {
        Console.Out.Write(" ");
      }
     Console.Out.WriteLine();
    }
    
   for(row = 0; row < 3; row++)
   {
     for(star = 0; star < 2 -row; star++)
     {
        Console.Out.Write("*");
     }
     Console.Out.WriteLine();
   }
  }
}
