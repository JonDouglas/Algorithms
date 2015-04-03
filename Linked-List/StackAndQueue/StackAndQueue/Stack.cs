using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack
    {
        private Node top;

        public Node Peek()
        {
            if (top != null)
            {
                return top;
            }

            return null;
        }

        public Node Pop()
        {
            if (top == null)
            {
                return null;
            }
            else
            {
                top = top.Next;
                return top;
            }
        }

        public void Push(Node node)
        {
            if (node != null)
            {
                node.Next = top;
                top = node;

            }
        }
    }
}
