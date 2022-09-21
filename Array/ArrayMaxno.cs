using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayMaxno
    {
        static void Main(string[] args)
        {
             int[] numbers = { 1,2,3,4,5,11,22,33,44,55 };
            int Max = numbers[1];
            {
                for (int i = 1; i < numbers.Length; i++)
                    if (numbers[i] > Max)
                    {
                        Max= numbers[i];
                    }
            }
            Console.WriteLine("maximum no is:"+Max);
        }
    }
}
