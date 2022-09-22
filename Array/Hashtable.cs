using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Hashtable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(91, "IND");
            ht.Add(1, "USA");
            ht.Add(63, "AUS");
            ht.Add(33, "FR");

            ht.Remove(1);

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine($"{d.Key}  {d.Value}");
            }

        }
    }
}
