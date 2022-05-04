namespace laba431
{
    class Program
    {
        class Student
        {
            public string name;
            public string surname;
            public int m;
            public int f;
            public int i;
        }
        static double srb(Student A)
        {
            double B = (double)(A.m + A.f + A.i) / 3;
            return B;
        }
        static Student[] fileread()
        {
            StreamReader sr = new StreamReader("C:\\Users\\Leonid\\Desktop\\in.txt");
            int a = int.Parse(sr.ReadLine());
            Console.WriteLine($"{a}");
            Student[] c = new Student[a];
            for (int i = 0; i < a; i++)
            {
                c[i] = new Student();
                string[] b = sr.ReadLine().Split(' ');
                Console.WriteLine($"{b[0]} {b[1]} {b[2]} {b[3]} {b[4]}");
                c[i] = new Student();
                c[i].surname = b[0];
                c[i].name = b[1];
                c[i].m = int.Parse(b[2]);
                c[i].f = int.Parse(b[3]);
                c[i].i = int.Parse(b[4]);
            }
            Console.WriteLine("\n");
            return c;
        }
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Leonid\\Desktop\\out.txt"))
            {
                Student[] A = fileread();
                for (int i = 0; i < A.Length; i++)
                {
                    double D = srb(A[i]);
                    Console.Write("Средняя оценка {0 , 11} = {1:F1}", A[i].surname, D);
                    if (A[i].m > 3 && A[i].f > 3 && A[i].i > 3)
                    {
                        Console.WriteLine(" +");
                        sw.Write("{0} {1:F1}\n", A[i].surname, D);
                    }
                    else Console.WriteLine("");
                }
            }



        }
    }
}
