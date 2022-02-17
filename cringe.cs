
using System;
class HelloWorld {
  static void Main() {
    Console.Writeline("Введите число a");
    double a = Console.ReadLine();
    Console.Writeline("Введите число t");
    double t = Console.ReadLine();
    double l1 = a*(t*t);
    double l2 = Math.Log(l1);
    double y1 = Math.Exp(l2);
    Console.Write(y1);
  }
}
