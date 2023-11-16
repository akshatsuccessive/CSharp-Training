using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Array
    {
        public static void Method()
        {
            int[] array1 = new int[5];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;
            array1[3] = 40;
            array1[4] = 50;
            //array1[5] = 60; 

            for (int i = 0; i < 5; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine("\n");

            int[] array2 = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine("\n");

            int[,] array2D = new int[2, 3];
            array2D[0,0] = 1;
            array2D[0,1] = 2;
            array2D[0,2] = 3;
            array2D[1,0] = 4;
            array2D[1,1] = 5;
            array2D[1,2] = 6;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");


            int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(multiDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            int[][] jaggedArray = new int[6][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[5] { 84, 42, 90, 11, 56 };
            jaggedArray[2] = new int[2] { 13, 54 };
            jaggedArray[3] = new int[1] { 99 };
            jaggedArray[4] = new int[4] { 19, 22, 93, 42 };
            jaggedArray[5] = new int[2] { 51, 1 };

            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
