using System;

//*****
// ***
//  *
			
public class ForLoopUpsideDown
{
    public static void Main()
    {
      int row, space, leftHalfStar, rightHalfStar, loop = 5;
    		
      	// iterates each row   
      	for (row = 5; row >= 1; row--)
        {
            for (space = 0; space < (loop - row); space++)
            {
                Console.Write("0");        
            }
      			// prints left half of the star
          	for (leftHalfStar = 1; leftHalfStar <= row; leftHalfStar++)
            {
                Console.Write("*");
            }
      			// prints right half of the star
            for (rightHalfStar = 1; rightHalfStar < row; rightHalfStar++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}