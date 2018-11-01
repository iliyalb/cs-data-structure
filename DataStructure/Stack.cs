using System;

namespace DataStructure
{
    class Stack
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

        internal void Push(Node node)
        {
            node.next = first;
            first = node;
        }

        internal void Pop()
        {
            first = first.next;
        }

        internal void Print()
        {
            Node node = first;
            while (node != null)
            {
                Console.WriteLine("|" + node.value + "|");
                node = node.next;
            }
        }
    }
}
