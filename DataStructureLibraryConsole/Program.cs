using System;
using DataStructureLibrary;

namespace DataStructureLibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var queue = new Queue<int>();
            //queue.AddLast(1);
            //queue.AddLast(2);
            //queue.AddLast(3);


            var stack = new Stack<int>();
            for (var idx = 0; idx < 100; idx++)
            {
                stack.Push(idx);
            }
            while (!stack.Empty)
            {
                Console.WriteLine($"{stack.Pop()},");
            }

        }
    }
}
