using System;

namespace _2_laba_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int m = 5, n = 8;
            int c = 0;
            Random rnd = new Random();
            int[,] M = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = rnd.Next(-10, 10);
                    Console.Write($"{M[i, j]}\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            int l = 11;
            for (int i = 0; i < M.GetLength(1); i++) {
                int min = M[0, i];
                for (int j = 0; j < M.GetLength(0); j++)
                {
                    if (M[j, i] < min) min = M[j, i];
                }
                Console.WriteLine($"Минимальный элемент {i + 1}  столбца: {min}");
            }
            int count = 0;
            int overall = 0;

            foreach (int f in M) if (f < 0) { count++; overall += f; }

            Console.WriteLine(overall/count);

        }
    }
}
