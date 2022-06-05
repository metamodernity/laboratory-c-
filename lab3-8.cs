using System;
class Program
{
static Random r = new Random();
static int[,] input(int[,] a, int n, int m)
{
a = new int[n, m];
for (int i = 0; i < n; i++)
for (int j = 0; j < m; j++)
a[i, j] = r.Next(0, 100);
return a;
}
static void output(int[,] a)
{
for (int i = 0; i < a.GetLength(0); i++)
{
for (int j = 0; j < a.GetLength(1); j++)
Console.Write(a[i, j] + " ");
Console.WriteLine();
}
Console.WriteLine();
}
static int max(int[,] a)
{
int sum = 0;
for (int j = 0; j < a.GetLength(1); j++)
{
int max = a[0, j];
for (int i = 1; i < a.GetLength(0); i++)
max = (a[i, j] > max ? a[i, j] : max);
sum += max;
}
return sum;
}
static void Main(string[] args)
{
int[][,] mas = new int[3][,];
mas[0] = input(mas[0], 2, 2); mas[1] = input(mas[1], 3, 2); mas[2] = input(mas[2], 2, 3);
int sum = 0;
for (int i = 0; i < 3; i++)
{
Console.Write($"{i + 1} матрица:\n");
output(mas[i]);
sum += max(mas[i]);
}
Console.WriteLine($"Сумма максимумов столбцов: {sum}");
}
}
