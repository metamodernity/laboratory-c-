using System;

namespace _2_laba_3_6
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("\n\nlaba 3.6.1\n\n");


string string1 = "third laboratory work , sixth task"; // 5 слов


int z = 0;
int k = 0;
int n = string1.Length;

for (int i=0; i < n; i++)
{
char c = string1[i];
if (c != ' ')
{
for (; i < n && c != ' ' ; i++)
{
c = string1[i];
k++;
}
}
if (k > 1) z++;
k = 0;
}
Console.WriteLine($"{string1}");
Console.WriteLine($"{z} слов");
}
}
}
