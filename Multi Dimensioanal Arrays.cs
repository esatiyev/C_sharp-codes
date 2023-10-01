using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;
           // matrix ={ { "1","2"},{ "3","4" } };   //this is wrong,don't do like that
            
            // declare 3D array
            string[,,] matrix3;



            int[,] array2D = new int[,] 
            { 
                { 1,2,3},
                { 4,5,6},
                { 7,8,9} 
            };
            Console.WriteLine("Central Value is {0}", array2D[1,1]);

            
            // string array three dimensional
            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011" },
                    {"hi ","name"}
                },
                {
                    {"100","101" },
                    {"110","111" },
                    {"uc","naber" }
                }
            };
            Console.WriteLine("The value is {0}", array3D[1,2,1]);



            //string two dimensional
            string[,] array2DString = new string[,] 
            { 
                { "one", "two" },
                { "three", "four" },
                { "five", "six" }
            };
            Console.WriteLine("Last element of array2DString is {0}", array2DString[2,1]);

            //change elements of array
            array2DString[2, 1] = "Chicken";
            Console.WriteLine("New last element of array2DString is {0}",array2DString[2,1]);


            int length = array2DString.Length; // Get number of total elements of array  
            
            int dimensions = array2DString.Rank; // Get dimension of array
            
            Console.WriteLine("Length of array2DString is {0}",length);
           
            Console.WriteLine("The dimension of array2DString is {0}",dimensions);



            int[,] array2D2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; 


            Console.Read();
        }

    
    }
}
