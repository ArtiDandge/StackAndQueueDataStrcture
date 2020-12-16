using System;

namespace StackAndQueueDataStrcture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Welcome to the Project on Stacks and Queue Data Structure---------");
            LinkedListStack stack = new LinkedListStack();
            Console.WriteLine("-------------------Stack Operations------------------");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("\nStack contains following value");
            stack.Display();
            Console.WriteLine("\n");
            stack.Peek();
            stack.IsEmpty();
            stack.Display();
            Console.WriteLine("-------------------Stack Operations End------------------");
            Console.WriteLine("\n");
            Console.WriteLine("-------------------Queue Operations------------------");
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.WriteLine("-------------------Queue Operations End------------------");
        }
    }
}
