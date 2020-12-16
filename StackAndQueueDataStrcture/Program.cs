using System;

namespace StackAndQueueDataStrcture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Welcome to the Project on Stacks and Queue Data Structure---------");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("\nStack contains following value");
            stack.Display();
            Console.WriteLine("\n");
            stack.Peek();
            stack.IsEmpty();
            stack.Display();
        }
    }
}
