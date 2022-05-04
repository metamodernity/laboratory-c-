using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    class Program
    {
        static ObjInSpace InputAsDouble()
        {
            double phi, lambda, h;
            Console.Write("Широта: ");
            phi = Double.Parse(Console.ReadLine());
            Console.Write("Долгота: ");
            lambda = Double.Parse(Console.ReadLine());
            Console.Write("Высота над уровнем моря: ");
            h = Double.Parse(Console.ReadLine());
            ObjInSpace obj_in_space = new ObjInSpace(phi, lambda, h);
            return obj_in_space;
        }

        static ObjInSpace InputAsDMS()
        {
            string phi, lambda, h;
            Console.Write("Широта: ");
            phi = Console.ReadLine();
            Console.Write("Долгота: ");
            lambda = Console.ReadLine();
            Console.Write("Высота над уровнем моря: ");
            h = Console.ReadLine();
            ObjInSpace obj_in_space = new ObjInSpace(phi, lambda, h);
            return obj_in_space;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество объектов: ");
            short N = Int16.Parse(Console.ReadLine());

            ObjInSpace[] objects_arr = new ObjInSpace[N];
            Console.WriteLine("Выберите формат ввода:");
            Console.WriteLine("1 - градусы");
            Console.WriteLine("2 - градусы, минуты, секунды");
            string input = Console.ReadLine();
            if (input == "1")
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Объект №{0}:", i + 1);
                    try
                    {
                        objects_arr[i] = InputAsDouble();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nВведены данные неверного формата! Повторите ввод.\n");
                        i--;
                    }
                }
            }
            else if (input == "2")
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Объект №{0}:", i + 1);
                    try
                    {
                        objects_arr[i] = InputAsDMS();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nВведены данные неверного формата! Повторите ввод.\n");
                        i--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - вывести на экран все координаты в вещественном формате");
                Console.WriteLine("2 - вывести на экран все координаты в формате ГМС");
                Console.WriteLine("3 - вывести на экран координаты объекта в вещественном формате");
                Console.WriteLine("4 - вывести на экран координаты объекта в формате ГМС");
                Console.WriteLine("5 - изменить координаты объекта");
                Console.WriteLine("0 - закрыть программу");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            for (int i = 0; i < N; i++)
                            {
                                Console.WriteLine("Объект №{0}:", i + 1);
                                Console.WriteLine(objects_arr[i].ToStringAsDouble());
                            }
                            break;
                        }
                    case "2":
                        {
                            for (int i = 0; i < N; i++)
                            {
                                Console.WriteLine("Объект №{0}:", i + 1);
                                Console.WriteLine(objects_arr[i].ToString());
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Номер объекта: ");
                            short number = Int16.Parse(Console.ReadLine());
                            Console.WriteLine(objects_arr[number - 1].ToStringAsDouble());
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Номер объекта: ");
                            short number = Int16.Parse(Console.ReadLine());
                            Console.WriteLine(objects_arr[number - 1].ToString());
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Номер объекта: ");
                            short number = Int16.Parse(Console.ReadLine());

                        ChangeCoord:

                            Console.WriteLine("Выберите формат ввода:");
                            Console.WriteLine("1 - градусы");
                            Console.WriteLine("2 - градусы, минуты, секунды");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                double phi, lambda, h;
                                try
                                {
                                    Console.Write("Широта: ");
                                    phi = Double.Parse(Console.ReadLine());
                                    Console.Write("Долгота: ");
                                    lambda = Double.Parse(Console.ReadLine());
                                    Console.Write("Высота над уровнем моря: ");
                                    h = Double.Parse(Console.ReadLine());
                                    objects_arr[number - 1].SetNewPosition(phi, lambda, h);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nВведены данные неверного формата! Повторите ввод.\n");
                                    goto ChangeCoord;
                                }
                            }
                            else if (input == "2")
                            {
                                string phi, lambda, h;
                                try
                                {
                                    Console.Write("Широта: ");
                                    phi = Console.ReadLine();
                                    Console.Write("Долгота: ");
                                    lambda = Console.ReadLine();
                                    Console.Write("Высота над уровнем моря: ");
                                    h = Console.ReadLine();
                                    objects_arr[number - 1].SetNewPosition(phi, lambda, h);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("\nВведены данные неверного формата! Повторите ввод.\n");
                                    goto ChangeCoord;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода.");
                                break;
                            }
                            Console.WriteLine("Координаты объекта изменены.");
                            objects_arr[number - 1].ToString();
                            break;
                        }
                    case "0":
                        {
                            exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка ввода.");
                            break;
                        }
                }
            }
        }
        class ObjInSpace
        {
            double phi;
            double lambda;
            double h;

            struct DMSFormat
            {
                public double degrees;
                public double minuts;
                public double seconds;
                public string flag;
            };

            DMSFormat GetPhiAsDMS()
            {
                DMSFormat result = new DMSFormat();
                if (Phi >= 0) result.flag = "N";
                else result.flag = "S";
                result.degrees = Math.Abs(Math.Truncate(Phi));
                result.minuts = (Math.Abs(Phi) - result.degrees) * 60;
                result.seconds = (result.minuts - Math.Truncate(result.minuts)) * 60;
                result.minuts = Math.Truncate(result.minuts);
                return result;
            }

            DMSFormat GetLambdaAsDMS()
            {
                DMSFormat result = new DMSFormat();
                if (Lambda >= 0) result.flag = "E";
                else result.flag = "W";
                result.degrees = Math.Abs(Math.Truncate(Lambda));
                result.minuts = (Math.Abs(Lambda) - result.degrees) * 60;
                result.seconds = (result.minuts - Math.Truncate(result.minuts)) * 60;
                result.minuts = Math.Truncate(result.minuts);
                return result;
            }

            public double Phi
            {
                get
                {
                    return phi;
                }
                set
                {
                    if ((value >= -90) && (value <= 90))
                    {
                        phi = value;
                    }
                    else
                    {
                        throw new System.FormatException();
                    }
                }
            }

            public double Lambda
            {
                get
                {
                    return lambda;
                }
                set
                {
                    if ((value >= -180) && (value <= 180))
                    {
                        lambda = value;
                    }
                    else
                    {
                        throw new System.FormatException();
                    }
                }
            }

            public double H
            {
                get
                {
                    return h;
                }
                set
                {
                    if ((value >= -10000) && (value <= 10000))
                    {
                        h = value;
                    }
                    else
                    {
                        throw new System.FormatException();
                    }
                }
            }

            public ObjInSpace()
            {
            }

            public ObjInSpace(double phi, double lambda, double h)
            {
                Phi = phi;
                Lambda = lambda;
                H = h;
            }

            public ObjInSpace(string phi, string lambda, string h)
            {
                string[] phi_arr = phi.Split(' ', '\'', '\"');
                Phi = Double.Parse(phi_arr[0]) + Double.Parse(phi_arr[1]) / 60 + Double.Parse(phi_arr[2]) / 3600;
                if (phi_arr[3] == "S") Phi = -Phi;

                string[] lambda_arr = lambda.Split(' ', '\'', '\"');
                Lambda = Double.Parse(lambda_arr[0]) + Double.Parse(lambda_arr[1]) / 60 + Double.Parse(lambda_arr[2]) / 3600;
                if (lambda_arr[3] == "W") Lambda = -Lambda;

                H = Double.Parse(h);
            }

            public void SetNewPosition(double phi, double lambda, double h)
            {
                Phi = phi;
                Lambda = lambda;
                H = h;
            }

            public void SetNewPosition(string phi, string lambda, string h)
            {
                string[] phi_arr = phi.Split(' ', '\'', '\"');
                Phi = Double.Parse(phi_arr[0]) + Double.Parse(phi_arr[1]) / 60 + Double.Parse(phi_arr[2]) / 3600;
                if (phi_arr[3] == "S") Phi = -Phi;

                string[] lambda_arr = lambda.Split(' ', '\'', '\"');
                Lambda = Double.Parse(lambda_arr[0]) + Double.Parse(lambda_arr[1]) / 60 + Double.Parse(lambda_arr[2]) / 3600;
                if (lambda_arr[3] == "W") Lambda = -Lambda;

                H = Double.Parse(h);
            }

            public string ToStringAsDouble()
            {
                string result = "";
                result += String.Format("{0:0.000000}\n{1:0.000000}\n{2} meters", Phi, Lambda, H);
                return result;
            }

            public override string ToString()
            {
                string result = "";
                DMSFormat buffer = GetPhiAsDMS();
                result += String.Format("{0} {1}\'{2:0.0000}\"{3}\n", buffer.degrees, buffer.minuts, buffer.seconds, buffer.flag);
                buffer = GetLambdaAsDMS();
                result += String.Format("{0} {1}\'{2:0.0000}\"{3}\n", buffer.degrees, buffer.minuts, buffer.seconds, buffer.flag);
                result += H + " meters";
                return result;
            }

        }

    }
}
