// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Collections;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        double d = 6.7;
        int sayi = Convert.ToInt32(d);
        Console.WriteLine(sayi);
        int num = int.Parse("10");
        Console.WriteLine(num);
        Console.WriteLine(num.GetType());
        
        int result;
        int.TryParse("10", out result);
        Console.WriteLine("\n"+result+ " ? " );
        
        int n = (int)d;
        float f = (float)4.3;
        Console.WriteLine("\n"+n + " "+f );
        
        Console.WriteLine("\n");
        
        ArrayList l = new ArrayList();
        l.Add(4);
        l.Add(true);
        l.Add("String");
        l.Insert(2, "2nd");
        foreach(var l1 in l){
            Console.WriteLine(l1 + " " );
        }
        Console.WriteLine("\n {0}", l.Count );
        Console.WriteLine("\n {0} {1}", l[1] , l[1].GetType());
        
        int[] dizi1;
        dizi1 = new int[2];
        dizi1[0] =1;
        dizi1[1] =2;
        Console.WriteLine("\n");
        // string ad = "Elton" => ad.Length : ad[0]; ad[1];
        for(int j = 0; j<dizi1.GetLength(0); j++){  //or dizi1.Length
            Console.WriteLine(dizi1[j] + " ");
        }
        
        string[] sDizi = {"e", "s"};
        string[] sDizi2 = new string[] {"e", "s"};
        float[] fDizi = {5.0F, 3.5F};
        
        int[] d1, d2 = new int[3];
        // d1[0] = 1;  ERROR
        d2[0] =2;   // Correct
        
        Console.WriteLine("\n");
        
        //int[,] ikiBoyut;
        //int[,] ikiBoyut = new int[4, 2];
        int[,] ikiBoyut = {
                            {1,2},
                            {3,4},
                            {5,6},
                            {7,8}
                          };
        for (int i= 0; i < ikiBoyut.GetLength(0); i++){
            for (int j = 0; j < ikiBoyut.GetLength(1); j++){
                Console.WriteLine(ikiBoyut[i,j] + " ");
            }
        }
        
        ikiBoyut[0, 0] = 10;
        ikiBoyut[0, 1] = 20;
        ikiBoyut[1, 0] = 30;
        ikiBoyut[1, 1] = 40;
        ikiBoyut[2, 0] = 50;
        ikiBoyut[2, 1] = 60;
        ikiBoyut[3, 0] = 70;
        ikiBoyut[3, 1] = 80;
        
        Console.WriteLine("\n");
        for (int i= 0; i < ikiBoyut.GetLength(0); i++){
            for (int j = 0; j < ikiBoyut.GetLength(1); j++){
                Console.WriteLine(ikiBoyut[i,j] + " ");
            }
        }
        
        
        Console.WriteLine("\n\n3 Boyutlu Diziler");
        // Çok Boyutlu Diziler
        // Üç Boyutlu Diziler
        //int[] ucBoyut;
        //int[,,] ucBoyut = new int [4, 2, 2];
        int[,,] ucBoyut = {
                            {{1,2}, {3,4} },
                            {{ 5,6 }, { 7,8 } },
                            {{9,10 }, { 11,12}},
                            {{13,14 }, { 15,16 } }
                          };
        for (int i = 0; i < 4; i++){
            for (int j= 0; j < 2; j++){
                for (int k = 0; k < 2; k++){
                    Console.WriteLine(ucBoyut[i, j, k]);
                }
            }
        }
        ucBoyut[0, 0, 0] = 100;
        
        
        Console.WriteLine("\n\nJagged Array");
        // Jagged Array
        int[][] jagged = {
                            new int[] {1, 2, 3},
                            new int[] {4, 5, 6},
                            new int[] {7, 8, 9}
                        };
        foreach(var jag in jagged){
            foreach(var eleman in jag){
                Console.Write(eleman + " ");
            }
            Console.WriteLine("\n");
        }
        
        Console.ReadLine();
    }
}
