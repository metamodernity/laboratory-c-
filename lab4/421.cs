namespace laba421
{
    enum spec { ИВТ, РПИС, УИТС, ПО };
    class Student
    {
        public string name;
        public spec sp;
    }
    class Program
    {
        static void print(Student[] a)
        {
            for (int i = 0; i < a.Length; i++) Console.Write("{0}-{1} ", a[i].name, a[i].sp);
            Console.WriteLine("");
        }
        static Student[] genm(Student[] a, Student d)
        {
            int n = a.Length;
            Array.Resize(ref a, a.Length + 1);
            a[n] = d;
            return a;
        }
        static void Main(string[] args)
        {
            Student[] c = new Student[9];
            for (int i = 0; i < 9; i++) c[i] = new Student();
            c[0].name = "Бусаев"; c[1].name = "Федотов"; c[2].name = "Адашев"; c[3].name = "Ляпин"; c[4].name = "Бусаев";
            c[5].name = "Иванов"; c[6].name = "Соколова"; c[7].name = "Петров"; c[8].name = "Котов";
            c[0].sp = c[1].sp = c[2].sp = spec.ИВТ;
            c[3].sp = spec.ПО;
            c[4].sp = c[5].sp = spec.УИТС;
            c[6].sp = c[7].sp = c[8].sp = spec.РПИС;
            for (int i = 0; i < 9; i++) Console.WriteLine("{0}-{1}", c[i].name, c[i].sp);
            Console.Write("\nКолличество специальностей: 4\nКолличество студентов: 9" +
            "\nВведите количесвто групп (не более 9-ти):");


            int n = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            Student[][] A = new Student[n][];
            for (int i = 0; i < n; i++) A[i] = new Student[0];
            for (int i = 0; i < 9; i++)
            {
                if (A[m].Length != 0 && c[i].sp == A[m][A[m].Length - 1].sp && m != n - 1) m++;
                A[m] = genm(A[m], c[i]);
                m++;
                if (m == n) m = 0;
            }
            Console.WriteLine($"{A.Length}");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Группа {0} ", i + 1);
                print(A[i]);
            }

        }
    }
}
