using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            /*   Stack stack = new Stack();

               stack.Add(55);
               stack.Add(20);
               stack.Add(66);
               stack.Add(10);
 
               stack.push(10);
               stack.pop(66);
               stack.peek(20)
               Console.WriteLine(stack.Count);
               foreach (var item in stack)
               {
                   Console.WriteLine(item);
               }
            */
            // (queue)

           Queue queue = new Queue();


            queue.add(32);
            queue.add(45);
            queue.add(20);
            queue.add(26);

            queue.Enqueue(20);
            queue.Dequeue(26);
            queue.Peek(32);
            Console.WriteLine(queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

    }
}
