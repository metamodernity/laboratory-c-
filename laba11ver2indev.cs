using System;
class Programm

{
    static void Main()
    {
        double dter;
        double hight1;
        double low1;
        double lncosx;
        double d = 1;
        double t = 2;
        double e = 3;
        double r = 4;
        double x = 5;
        double b = 6;
        double a = 6;
        double result;
        dter = ((Math.Pow((d), t)) * (Math.Pow((e), r)));
        lncosx = (Math.Log10(Math.Cos(x)));
        hight1 = 2*Math.Sin((Math.Exp(Math.Log10(a * t * t)))) - Math.Cos(Math.Exp(Math.Log10(b)));
        low1 = 9 + ((lncosx * lncosx) + (dter * dter) + (6 * lncosx)  + (6 * dter) + ((2 * lncosx) * dter));
        result = hight1 / low1;
        Console.WriteLine($"{result}");
    }
}
/* Считаем единицы:
 * присвоение (1 ед.) = 7 за переменные, 5 за вычисления = 12
 * сложение и вычитание (3 ед.) = 5 раз = 15
 * умножение (5 ед.) = 10 раз = 50
 * деление (7 ед.) = 1 раз = 7
 * вызов стандартной функции (13 ед.) = 11 раз = 143
 * ИТОГО: 227 ЕДИНИЦ
/*a1 = (2*Math.Sin(Math.Exp(Math.Log10(a * t * t)) + Math.Exp(Math.Log10(b)))/2)*(Math.Cos(Math.Exp(Math.Log10(a*t*t) - Math.Exp(Math.Log(b)))));
        a2 = 9 + ((Math.Log10(Math.Cos(x)))) *c(Math.Log10(Math.Cos(x))));
        a3 = a1 / a2;*/
/*Console.WriteLine($"{b1}");
        Console.Write($"{a}");*/
