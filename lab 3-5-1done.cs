using System;

namespace _2_laba_3_5
{
class Program
{

static void Main(string[] args)
{
Random rnd = new Random();
Console.WriteLine("\n\nlaba 3.5.1\n\n");
int[,] mass5 = new int[3, 4];
int[] sdt = new int[2];
int st1 = 6;
for (int i = 0; i < 3; i++)
{
for (int j = 0; j < 4; j++)

{
mass5[i, j] = rnd.Next(0, 7);
Console.Write("{0} ", mass5[i, j]);
}
Console.WriteLine();
}
int d = 0, o1 = 0, o2 = 0;
while (d < 3)
{
for (int j2 = 0; j2 < 4; j2++)
{
if (mass5[d, j2] < st1)
{
st1 = mass5[d, j2];
o1 = j2;
}
}
for (int i2 = 0; i2 < 3; i2++)
{
if (st1 < mass5[i2, o1]) break;
else o2++;
}
if (o2 == 3)
{
Console.WriteLine($"\n строка {d} столбец {o1}\n");
d = 0;
break;
}
else
{
o1 = 0;
st1 = 6;
d++;
o2 = 0;
}
}
if (d != 0) Console.WriteLine("\n0");

}
}
}
