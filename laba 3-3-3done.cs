using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] myInts = new int[15];
            for (int i = 0; i < 15; i++)
            {
                myInts[i] = rnd.Next(-10, 10);
                Console.WriteLine("myInts[{1}]= {0}", myInts[i], i);
            }
            int result = 0;

            int min_index = Array.FindIndex(myInts, delegate (int i) { return i == myInts.Min(); });
            int max_index = Array.FindIndex(myInts, delegate (int i) { return i == myInts.Max(); });
            int a1 = 0;
            int a2 = 0;
            if (min_index > max_index)
            {
                 a1 = max_index;
                 a2 = min_index;
            }
            else
            {
                 a1 = min_index;
                 a2 = max_index;
            }
            for (int i = a1 + 1; i < a1 + (a2 - a1); i++)
            {
                if (myInts[i] > 0)
                    result += myInts[i];
            }
            Console.WriteLine("Result is: {0}", result);
            Console.WriteLine("MIN={0}", min_index);
            Console.WriteLine("MAX={0}", max_index);
            Console.ReadLine();

        }
    }
}
