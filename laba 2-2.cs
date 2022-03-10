using System;
class Programm

{
    static int Sum2(int n = 0)
    {
        return (n = n < 10 ? 10 : n) < 100 ? n + Sum2(n + 1) : 0;
    }
    static void Main()
    {
        int a = Sum2(10);
        Console.WriteLine($"{a}");
    }
}
