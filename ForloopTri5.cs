using System;
			
public class ForloopTri5
{
    public static void Main()
    {
        // rowLength can be set to any number
        int currentRow, star, space, rowLength = 3, entireRow = rowLength * 2 - 1;
        
        for(currentRow = 0; currentRow < entireRow; currentRow++)
        {
            int starCol = rowLength - currentRow;
            
            if(currentRow < rowLength)
            {
                for(space = 0; space < rowLength - 1 - currentRow; space ++)
                {
                    Console.Out.Write(" ");
                    //Console.Out.Write(starCol);          
                }
                for(star = 0; star < currentRow + 1; star ++)
                {
                    Console.Out.Write("*");
                }
            }
            else
            {
                starCol = entireRow - currentRow;
                int currentSpaceRow = 0;
                
                for(space = 0; space < rowLength - starCol; space ++)
                {
                    //Console.Out.Write(currentRow);
                    Console.Out.Write(" ");          
                }
                for(star = 0; star < starCol; star++)
                {
                    //Console.Out.Write(currentRow);
                    Console.Out.Write("*");
                }
            }
            
            Console.Out.WriteLine();
        }
    }
}