using System;

namespace _2_laba_3_1_1
{
    class Program
    {
        static int fn1(int[] mass)
        {

            int a = mass.Length, b = 0;
            for (int i = 0; i < a; i++) if ((mass[i] < 0)) b++;
            return b;
        }
        static int fn2(int[] mass)
        {
            int a = mass.Length, b = 0;
            for (int i = 0; i < a; i++) if (mass[i] % 2 == 0) b += mass[i];
            return b;
        }
        static int fn3(int[] mass)
        {

            int a = mass.Length, b = 0, max = 0;
            for (int i = 0; i < a; i++) if (mass[i] > max)
                {
                    max = mass[i];
                    b = i;
                }
            return b;
        }
        static int fn4(int[] mass)
        {
            int a = mass.Length, b = 0;
            for (int i = 0; i < a; i++) if (mass[i] == 0) b++;
            return b;
        }
        static void fn5(int[] mass)
        {
            int a = mass.Length;
            for (int i = 0; i < a; i++) if ((i % 2) != 1) Console.WriteLine("a[{0}]= {1}\n", i, mass[i]);
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mass = new int[15];
            for (int i = 0; i < 15; i++)
            {
                mass[i] = rnd.Next(-150, 150);
                Console.WriteLine("mass[{1}]= {0}", mass[i], i);
            }
            Console.WriteLine($"\n\nРасчет количества отрицательных чисел: {fn1(mass)}\n");
            Console.WriteLine($"Расчёта суммы чётных чисел: { fn2(mass)}\n");
            Console.WriteLine($"Индекс максимального положительного числа: { fn3(mass)}\n");
            Console.WriteLine($"определение есть ли в массиве нулевые значения: { fn4(mass)}\n");
            Console.WriteLine($"вывод ячеек с чётными индексами по формату: a[i]=x\n");
            fn5(mass);
        }
    }
}
