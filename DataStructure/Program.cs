using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List:");
            LinkedList L = new LinkedList();
            L.AddAtFront(new LinkedList.Node(1));
            L.AddAtFront(new LinkedList.Node(2));
            L.AddAtFront(new LinkedList.Node(4));
            L.AddAtEnd(new LinkedList.Node(8));
            L.Print();

            Console.WriteLine("\n\nStack:");
            Stack S = new Stack();
            S.Push(new Stack.Node(1));
            S.Push(new Stack.Node(2));
            S.Push(new Stack.Node(4));
            S.Push(new Stack.Node(8));
            S.Print();

            Console.WriteLine("\n\nQueue:");
            Queue Q = new Queue();
            Q.Enqueue(new Queue.Node(1));
            Q.Enqueue(new Queue.Node(2));
            Q.Enqueue(new Queue.Node(4));
            Q.Enqueue(new Queue.Node(8));
            Q.Print();

            Console.WriteLine("\n\nMatrix Graph:");
            Matrix.Graph MG = new Matrix.Graph(5);
            MG.AddEdge(1, 2);
            MG.AddEdge(1, 5);
            MG.AddEdge(2, 3);
            MG.AddEdge(2, 4);
            MG.AddEdge(2, 5);
            MG.AddEdge(3, 4);
            MG.AddEdge(4, 5);
            MG.Print();

            Console.WriteLine("\n\nBinary Tree:");
            BinaryTree T = new BinaryTree();
            T.Insert(5);
            T.Insert(3);
            T.Insert(8);
            T.Insert(1);
            T.Insert(4);
            T.Insert(7);
            T.Insert(9);
            T.Insert(0);
            T.Insert(2);
            T.Insert(6);
            T.Insert(10);
            T.Print(T.root, 0, 0);

            Console.WriteLine("\n\nHash Table:");
            HashTable.HashMap H = new HashTable.HashMap();
            H.Insert("A");
            H.Insert("B");
            H.Insert("C");
            Console.WriteLine(H.Search("B").value);

            Console.WriteLine("\n\nMatrice Addition:");
            Matrices matrice = new Matrices();
            int[,] a =
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 }
            };
            int[,] b =
            {
                {12,11,10,9 },
                {8,7,6,5 },
                {4,3,2,1 }
            };
            matrice.Print(matrice.Add(a, b));

            Console.WriteLine("\n\nMatrice Multiplication:");
            int[,] c =
            {
                {1,2 },
                {0,1 },
                {1,0 }
            };
            int[,] d =
            {
                {1 },
                {0 }
            };
            matrice.Print(matrice.Mul(c, d));

            Console.WriteLine("\n\nMatrice Transposition:");
            int[,] e =
            {
                {1,2,3,4 },
                {5,6,7,8 }
            };
            matrice.Print(matrice.Transpose(e));

            Console.ReadKey();
        }
    }
}
