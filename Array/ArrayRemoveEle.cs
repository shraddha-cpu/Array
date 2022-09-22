using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayRemoveEle
    {
        static void Main(string[] args)

        {
            int[] arr = new int[] { 23, 12, 67, 89, 34 };
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;  i< arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    arr[i] = 0;
                    break;
                }
            }
            foreach(var item in arr)
            {
                Console.WriteLine(item);    
            }

                                 //(OR)
          /*  int i = 0;
            int pos;
            int[] arr = new int[5] { 35, 50, 55, 77, 98 };

            Console.WriteLine("Elements before remove:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: "+arr[i]);
            }
            pos = 2;

            for (i = pos-1; i < 4; i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine("Elements after remove: ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: "+arr[i]);
            }
            Console.WriteLine();
          */
        }
    }
}
