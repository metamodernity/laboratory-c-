using System.Text;
using System;

namespace _2_laba_3_7
{
class Program
{
static void Main(string[] args)
{

Console.WriteLine("\n\nlaba 3.7.1\n\n");

Random rnd = new Random();
string str1 = "absdefgh1234567!?;";
Console.WriteLine("Введите размер строки");
int L = Convert.ToInt32(Console.ReadLine());
string str3 = "";
for (int i = 0; i < L; i++) str3 += " ";
StringBuilder str2 = new StringBuilder(str3);
for (int i = 0; i < L ; i++)
{
int rld = rnd.Next(0, 18);
str2[i] = str1[rld];
}
Console.WriteLine($"символы:\n{str1}\n");
Console.WriteLine($"Исходная строка:\n{str2}\n");
for (int i = 0; i < L; i++) if (str2[i] == ';') str2[i] = ' ';
Console.WriteLine($"Строка с заменой:\n{str2}\n");





}
}
}
