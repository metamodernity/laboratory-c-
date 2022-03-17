using System;

namespace laba32
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mass = new int[15];
            for (int i = 0; i < 15; i++)
            {
                mass[i] = rnd.Next(-50, 50);
                Console.WriteLine("mass[{1}]= {0}", mass[i], i);
            }
            Console.WriteLine("\n");
            int b, a = mass.Length;
            if ((a % 2) != 0) a--;
            for (int i = 0; i < a; i += 2)
            {
                b = mass[i];
                mass[i] = mass[i + 1];
                mass[i + 1] = b;
            }

            for (int i = 0; i < 15; i++) Console.WriteLine("mass[{1}]= {0}", mass[i], i);

        }
    }
}
