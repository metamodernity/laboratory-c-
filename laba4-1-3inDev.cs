using System;

namespace _4_1_3_
{
    class Position
    {
        int Position_One = 90;
        int Position_Two = 80;
        int Position_Three = 70;
        public void Print()
        {
            Console.WriteLine($"Широта: {Position_One}  Долгота: {Position_Two} Высота: {Position_Three}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Position xyz = new Position();
            xyz.Print();

        }
    }
}
