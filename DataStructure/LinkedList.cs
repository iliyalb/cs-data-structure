using System;

namespace DataStructure
{
    class LinkedList
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

        internal void AddAtFront(Node node)
        {
            node.next = first;
            first = node;
        }

        internal void AddAtEnd(Node node)
        {
            if (first == null)
                first = node;
            else
            {
                Node ptr = first;
                while (ptr.next != null)
                    ptr = ptr.next;
                ptr.next = node;
            }
        }

        internal void RemoveFront()
        {
            first = first.next;
        }

        internal void Print()
        {
            Node ptr = first;
            while (ptr != null)
            {
                Console.Write(ptr.value + " -> ");
                ptr = ptr.next;
            }
        }
    }
}
