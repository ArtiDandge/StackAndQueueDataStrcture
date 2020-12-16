using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueDataStrcture
{
    public class LinkedListQueue
    {
        internal Node head;
        /// <summary>
        /// Method to add elements to the Queue
        /// </summary>
        /// <param name="data"></param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("\n{0} inserted into Queue", node.data);
            }

        }

        /// <summary>
        /// Method to DeQueue Queue elements
        /// </summary>
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue empty");
            }
            else
            {
                Console.WriteLine("{0} Dequeued for the Queue ", head.data);
                head = head.next;               
            }
        }
        /// <summary>
        /// Method to display Queue 
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            Console.WriteLine("\nNow Queue has following data");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
