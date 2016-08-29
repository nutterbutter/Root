using System;
             
public class ForloopTri4
{
  public static void Main()
  {
    int row, grid = 5, num = 1;
     
    for(row = 0; row < grid; row++)
    {
      int rowSpace = grid-row-1;
      
      for(int space = 0; space < rowSpace; space++)
      {
        Console.Out.Write(" ");
      }
      for(int star = 0; star < num; star++)
      {
        Console.Out.Write("*");
      }
      num+=2;
      Console.Out.WriteLine();
    }
  }
}