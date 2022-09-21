﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class TwoDiamentional
    {
        static void Main(string[] args)
        {
            // 3 - row
            // 4- col
            int[,] arr = new int[3, 4]
            {
               { 1,2,3,4},
               {5,6,7,8 },
               {9,10,11,12 }
            };

            for (int i = 0; i < arr.GetLength(0); i++)  // GetLength(0) -> specifies row size
            {
                for (int j = 0; j < arr.GetLength(1); j++)  // GetLength(1)-> specifies col size
                {
                    Console.Write($"arr[{i},{j}]= {arr[i, j]}  ");
                }
                Console.WriteLine();
            }
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}


            

