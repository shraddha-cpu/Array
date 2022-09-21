using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayDivide
    {
        public static void splitArr(int[] arr, int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int x = arr[0];
                for (int j = 0; j < n - 1; ++j)
                    arr[j] = arr[j + 1];
                arr[n - 1] = x;
            }
        }
        static void Main(string[] args)
        {
        int[] arr = { 12, 10, 5, 6, 52, 36 };
        int n = arr.Length;
        int position = 3;
        splitArr(arr, n, position);
 
        for (int i = 0; i<n; ++i)
            Console.Write(arr[i] + " ");
        }
}
}
