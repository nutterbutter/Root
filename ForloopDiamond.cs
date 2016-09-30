using System;

public class ForloopDiamond
{  
    public static void Main()  
    {  
        int i,j,k,row;
        
        Console.Write("Enter the no. of row: ");  
        row = Convert.ToInt32( Console.ReadLine() );  
        
        for(i=1; i<=row; i++)  
        {
            for(j=row-i; j>=1; j--)
            {
                Console.Write(" ");
            }
            for(j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            for(k=i-1; k>=1; k--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for(i=row-1; i>=1; i--)
        {
            for(k=row-i; k>=1; k--)
            {
                Console.Write(" "); 
            }
            for(k=1; k<=(2*i-1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}