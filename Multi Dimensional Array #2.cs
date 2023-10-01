using System;

namespace MyApp
{
    internal class Program
    {
        static int[,] matrix =
        {
            { 1,2,3,4},
            { 5,6,7,8},
            { 9,10,11,12}
        };
        static void Main(string[] args)
        {
            //difference between foreach loop and nested for loop
            foreach(int item in matrix)
            {
                Console.Write(item + " "); // you cannot change item
                                           // ,but you can change item with nested for loop
            }
       


            Console.Write("\nThis is our 2D array printed using nested for loop : ");  //   \n  using for  new line
            // Nested for loop
            //outer for loop
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner for loop
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    // you can change element of array   
                    // for example :
                    // matrix[i,j] = 0;
                    Console.Write(matrix[i,j] + " ");   
                }
            }



            // difference between array.GetLength(dimension) and array.Length
            Console.WriteLine("\n The number of elements of specified dimension (here, it is zero) of matrix is "
                + matrix.GetLength(0));
            Console.WriteLine(" The number of elements of specified dimension (here, it is one) of matrix is "
                + matrix.GetLength(1));


            Console.Read();
        }

    
    }
}
