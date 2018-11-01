using System;

namespace DataStructure
{
    class BinaryTree
    {
        internal class Node
        {
            public int data;
            public Node left, right;
            public Node(int item)
            {
                data = item;
                left = null;
                right = null;
            }
        }

        internal Node root;
        private Random rand = new Random();
        internal BinaryTree()
        {
            root = null;
        }

        internal Node RecInsert(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }
            if (rand.Next(0, 2) % 2 == 0)
                root.left = RecInsert(root.left, data);
            else
                root.right = RecInsert(root.right, data);
            return root;
        }

        internal void Insert(int data)
        {
            root = RecInsert(root, data);
        }

        internal void Print(Node root, int space, int t)
        {
            const int COUNT = 3;
            if (root == null)
                return;
            space += COUNT;
            Print(root.right, space, 1);
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            if (t == 1)
                Console.WriteLine("/ " + root.data);
            else if (t == 2)
                Console.WriteLine("\\ " + root.data);
            else
                Console.WriteLine(root.data);
            Print(root.left, space, 2);
        }
    }
}
