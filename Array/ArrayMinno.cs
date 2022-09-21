using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayMinno
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 11, 22, 33, 44, 55 };
            int Min = numbers[1];
            {
                for (int i = 0; i < numbers.Length; i++)
                    if (numbers[i] < Min)
                    {
                        Min= numbers[i];
                    }
            }
            Console.WriteLine("minimum no is:"+Min);
        }
    }
}
