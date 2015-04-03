using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            Console.WriteLine("BEGIN STACK TEST ======================");
            Stack stack = new Stack();
            stack.Push(node1);
            Console.WriteLine("Push: " + node1.Value);
            stack.Push(node2);
            Console.WriteLine("Push: " + node2.Value);
            stack.Push(node3);
            Console.WriteLine("Push: " + node3.Value);
            stack.Pop();
            Console.WriteLine("Pop: " + stack.Peek().Value);
            stack.Pop();
            Console.WriteLine("Pop: " + stack.Peek().Value);
            stack.Push(node4);
            Console.WriteLine("Push: " + node4.Value);
            stack.Pop();
            Console.WriteLine("Pop: " + stack.Peek().Value);
            stack.Push(node5);
            Console.WriteLine("Push: " + node5.Value);
            Console.WriteLine("END STACK TEST ======================");

            Console.WriteLine("BEGIN QUEUE TEST ======================");
            Queue queue = new Queue();
            queue.Enqueue(node1);
            Console.WriteLine("Enqueue: " + node1.Value);
            queue.Enqueue(node2);
            Console.WriteLine("Enqueue: " + node2.Value);
            queue.Enqueue(node3);
            Console.WriteLine("Enqueue: " + node3.Value);
            Console.WriteLine("First Node: " + queue.FirstNode().Value);
            Console.WriteLine("Last Node: " + queue.LastNode().Value);
            Console.WriteLine("Dequeue: " + queue.FirstNode().Value);
            queue.Dequeue();
            Console.WriteLine("First Node: " + queue.FirstNode().Value);
            Console.WriteLine("Last Node: " + queue.LastNode().Value);
            Console.WriteLine("Dequeue: " + queue.FirstNode().Value);
            queue.Dequeue();
            Console.WriteLine("First Node: " + queue.FirstNode().Value);
            Console.WriteLine("Last Node: " + queue.LastNode().Value);
            Console.WriteLine("END QUEUE TEST ======================");
        }

    }
}
