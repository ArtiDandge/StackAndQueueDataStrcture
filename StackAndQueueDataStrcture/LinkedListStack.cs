using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueDataStrcture
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to the Stack", value);
        }

        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("\nNow {0} is on the top of the Stack", this.top.data);
        }

        internal void Display()
        {
            Node temp = this.top;
            if (this.top == null)
            {
                Console.WriteLine("\nCurrently Stack is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
