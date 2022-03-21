using System;

namespace _4_1_3_
{
    class Position
    {
        public int Position_One;
        public int Position_Two;
       public int Position_Three;
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
             xyz.Position_One = 90;
            xyz.Position_Two = 80;
            xyz.Position_Three = 70;
            xyz.Print();

            Position xyz2 = new Position();
            xyz2.Position_One = 70;
            xyz2.Position_Two = 80;
            xyz2.Position_Three = 90;
            xyz2.Print();
        }
    }
}
