using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson12Cs_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            while (stack.Count > 0)
            {
                Console.WriteLine($"War removed : {stack.Pop()}");
            }
            // Or method Clear()
            Stack<string> stack1 = new Stack<string>(new string[] { "Hop","Hey","Lalaley"});
            string[] str = { "one", "two", "three", "four" };
            stack1.CopyTo(str, 0);
            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Queue");
            Queue queue = new Queue();
            queue.Enqueue("back");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue()); 
            } // Clear Queue
        }
    }
}
