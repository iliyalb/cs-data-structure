using System;

namespace DataStructure
{
    class Matrix
    {
        private int[,] adjMatrix;
        private int variable;

        internal class Graph : Matrix
        {
            public Graph(int variable)
            {
                this.variable = variable;
                adjMatrix = new int[variable, variable];
            }
        }

        internal void AddEdge(int src, int dest)
        {
            adjMatrix[src - 1, dest - 1] = 1;
        }

        internal void RemoveEdge(int src, int dest)
        {
            adjMatrix[src - 1, dest - 1] = 0;
        }

        internal void Print()
        {
            for (int i = 0; i < variable; i++)
            {
                for (int j = 0; j < variable; j++)
                    Console.Write(adjMatrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
