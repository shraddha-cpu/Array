using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayString
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            string[]  n1 =  {"neha","shree","nikita","mansi","kishori" };
            string[] n2 = new string[5];
            Console.WriteLine("Original array");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("sorted array");
            //Array.Sort(names);
            // Array.Reverse(names);
            // Array.Clear(names, "shree", "shree");
            //Array.Copy(names, "neha, name, "neha", "mansi");
            //   Array.Copy(names, name, names.Length);
            //    int index = Array.IndexOf(names, "mansi");
            //    Console.WriteLine($"index of mansi is {index}");
            //    foreach (string name in name)
            //    {
            //        Console.WriteLine(name);
            //    }
        }
    }
}
