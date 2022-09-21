﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayMinTwodia
    {
        static void Main(string[] args)
        {
            const int x = 3, y = 5;
            int min;
            int[,] arr = new int[x, y] { { 10, 50, 13, 80, 40 }, { 1, 250, 65, 28, 15 }, { 12, 17, 45, 20, 6 } };
            min = arr[0, 0];
            for (int i = 0; i<x; i++)
            {
                for (int j = 0; j<y; j++)
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
            }
            Console.Write("Array Elements\n");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arr[i, j]+" ,");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Minimum  element:" + min);
            Console.ReadLine();
        }
    }
}
