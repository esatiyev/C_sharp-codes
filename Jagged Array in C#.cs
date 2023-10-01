using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // declare jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[3] { 2, 3, 4 };
            jaggedArray[2] = new int[2] { 3, 4 };

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 2, 3, 4 };
            jaggedArray[2] = new int[] { 3, 4 };

            //alternative way
            int[][]jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 2, 3, 4 },
                new int[] { 3, 4 }
             };

            Console.WriteLine("middle element of first entry : {0} ", jaggedArray2[0][2]);

            for(int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write ("element {0} : ",i);
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray[i][j]);
                }
            }


            // 3D jaggedArray
            int[][][] jaggedArray3 = new int[3][][];
            jaggedArray3[0] = new int[2][];
            jaggedArray3[1] = new int[1][];
            jaggedArray3[2] = new int[3][];

            jaggedArray3[0][0] = new int[1] {1};
            jaggedArray3[0][1] = new int[2] {3,4};
            jaggedArray3[1][0] = new int[5];
            jaggedArray3[2][0] = new int[3];
            jaggedArray3[2][1] = new int[2];
            jaggedArray3[2][2] = new int[6];

            jaggedArray3[0][0] = new int[] { 1 };
            jaggedArray3[0][1] = new int[] {  3, 4 };
            jaggedArray3[1][0] = new int[] { 3, 4,5,6,7 };
            jaggedArray3[2][0] = new int[] { 2, 4, 5 };
            jaggedArray3[2][1] = new int[] { 3, 4 };
            jaggedArray3[2][2] = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < jaggedArray3.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray3[i].Length; j++)
                {
                    Console.WriteLine("Element of element {0}", j);
                    for(int k = 0; k < jaggedArray3[i][j].Length; k++)
                    {
                        Console.WriteLine("{0}", jaggedArray3[i][j][k]);
                    }
                }
                
            }

            



            Console.Read();
        }

    
    }
}
