using System;
class Programm

{
    static void Main()
    {
        int a;
        {
            for (a = 1000; a <= 9999; a++)
            {
                string b = a.ToString();
                if (b[2] != b[3]) Console.WriteLine($"{a}");
            }
        }
    }
}
