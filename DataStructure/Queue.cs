using System;

namespace DataStructure
{
    class Queue
    {
        internal class Node
        {
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first = null;
        private Node last = null;

        internal void Enqueue(Node node)
        {
            if (last == null)
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
        }

        internal void Dequeue()
        {
            first = first.next;
            if (first == null)
                last = null;
        }

        internal void Print()
        {
            Node node = first;
            while (node != null)
            {
                Console.Write(node.value + " ");
                node = node.next;
            }
        }
    }
}
