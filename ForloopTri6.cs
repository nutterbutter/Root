// *****
//  ****
//   ***
//    **
//     *

using System;
			
public class ForloopTri6
{
  public static void Main()
  {
    int currentRow, star, space, rowLength = 5;
    
    for(currentRow = 0; currentRow < rowLength; currentRow++)
    {
      for(space = 0; space < currentRow; space ++)
      {
        Console.Out.Write(" ");
      }
      for(star = 0; star < rowLength - currentRow; star++)
      {
        Console.Out.Write("*");
      }
      
    	Console.Out.WriteLine();
    }
  }
}