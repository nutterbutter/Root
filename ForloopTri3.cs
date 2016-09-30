using System;
             
public class ForloopTri3
{
  public static void Main()
  {
    int row, star;
    int grid = 3;
    
    for(row = 0; row < grid*2; row++)
    {
      int _row = row +1;
      
        if (row >= grid)
        {
          _row = grid*2 - (row+1);
        }
        for(star = 0; star < _row; star++)
        {
          Console.Out.Write("*");
        }
     Console.Out.WriteLine();
    }
  }
}