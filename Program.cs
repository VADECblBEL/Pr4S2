using System;
using System.Collections;

namespace Pr4S2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("First");
            q.Enqueue("Second");
            q.Enqueue("Third");
            q.Enqueue("Fourth");

            while (q.Count > 0)
            {
                object obj = q.Dequeue();
                Console.WriteLine("From queue: {0}", obj);
            }

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From stack: {0}", obj);
            }
        }
    }
}
