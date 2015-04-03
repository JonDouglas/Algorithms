using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        private Node first, last;

        public void Enqueue(Node node)
        {
            if (first == null)
            {
                first = node;
                last = first;
            }
            else
            {
                last.Next = node;
                last = node;
            }
        }

        public Node Dequeue()
        {
            if (first == null)
            {
                return null;
            }
            else
            {
                Node temp = new Node(first.Value);
                first = first.Next;
                return temp;
            }
        }

        public Node FirstNode()
        {
            return first;
        }

        public Node LastNode()
        {
            return last;
        }
    }
}
