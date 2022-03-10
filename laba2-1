using System;
using System.Diagnostics;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i <= 1000000; i++) x1 = NumberOfOdds(i);
            sWatch.Stop();
            Console.WriteLine("Секунд для 1 000 000 повторов: " + (double)sWatch.ElapsedMilliseconds / 1000);
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine("В введенном числе {0} нечетных чисел", NumberOfOdds(number));
                Console.ReadLine();
            }
        }
        static int NumberOfOdds(int n)
        {
            int odd = 0;
            if (n % 2 != 0)
                odd++;
            if (n / 10 != 0)
                odd += NumberOfOdds(n / 10);
            return odd;
        }
    }
}
