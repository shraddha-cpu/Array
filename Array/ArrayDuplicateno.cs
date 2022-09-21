using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayDuplicateno
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 2, 7, 8, 8, 3 };

            Console.WriteLine("Duplicate elements in given array: ");
            //Searches for duplicate element  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }
        }
    }
}
