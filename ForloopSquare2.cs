// ***
// * *
// * *
// ***

using System;
			
public class ForloopSquare2
{
  public static void Main()
  {
    // numberOfRow and numberOfCol can be changed
    int row, col, numberOfRow = 4, numberOfCol = 3, lastRow = numberOfRow - 1, lastCol = numberOfCol - 1;
    
    for(row = 0; row < numberOfRow; row++)
    {
      for(col = 0; col < numberOfCol; col++)
      {
        // print the first and last rows of stars and the middle rows of stars at the first index and the last index
        if(row == 0 || row == lastRow || col == 0 || col == lastCol)
        {
          Console.Out.Write("*");
        }
        // print the spaces
        else
        {
          Console.Out.Write(" ");
        }
      }
      Console.Out.WriteLine();
    }
  }
}