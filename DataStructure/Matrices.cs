using System;

namespace DataStructure
{
    class Matrices
    {
        internal int[,] Add(int[,] a, int[,] b)
        {
            int[,] res = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    res[i, j] = a[i, j] + b[i, j];
            return res;
        }

        internal int[,] Mul(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int size = b.GetLength(0);
            int cols = b.GetLength(1);
            int[,] res = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int ret = 0;
                    for (int k = 0; k < size; k++)
                        ret += a[i, k] * b[k, j];
                    res[i, j] = ret;
                }
            }
            return res;
        }

        internal int[,] Transpose(int[,] a)
        {
            int[,] res = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    res[j, i] = a[i, j];

            return res;
        }

        internal void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
