using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArraySumno
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 11, 5, 76, 13, 40, 5 };
            int a= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=0; i < arr.Length; i++)
            {
                sum=arr[i];
                for(int j=i+1; j < arr.Length; j++)
                {
                    sum=sum +arr[j];
                    if(sum==a)
                    {
                        for(int K=i; K<=j; K++)
                        {
                            Console.WriteLine(arr[K]);
                        }
                        Console.WriteLine();
                    }
                    else if(sum>a)
                    {
                        break;
                    }
                }
            }
        }
    }
}
