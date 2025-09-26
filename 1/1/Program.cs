using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Xml;

namespace project
{
    class Program
    {
        public static void Main()
        {
            exercise_2();
        }
        public static void exercise_1()
        {
            while (true)
            {
                try
                {
                    uint a, b, c;
                    a = uint.Parse(Console.ReadLine());
                    b = uint.Parse(Console.ReadLine());
                    c = uint.Parse(Console.ReadLine());
                    Console.WriteLine($"{a} {b} {c}");

                    if (c > a || c > b)
                    {
                        Console.WriteLine("Not square");
                        break;
                    }
                    uint square_a = a / c;
                    uint square_b = b / c;
                    uint all_square = square_a * square_b;

                    uint area_all_square = c * c * all_square;
                    uint area_rectangle = a * b;
                    uint result = area_rectangle - area_all_square;
                    Console.WriteLine($"All square {all_square} Area not {result}");

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Negative numver");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("C no 0");
                }
            }
        }
        public static void exercise_2()
        {
            float contribution = 1000;
            float P = 0;
            int month = 0;
            do
            {
                Console.WriteLine("Enter P >0 P < 25");
                P = float.Parse(Console.ReadLine());

            } while (P <= 0 || P > 25);
            while (contribution < 1100)
            {
                month++;
                contribution += contribution * (P / 100);
                Console.WriteLine("Month " + month + " Contribution "+ contribution);
            }
        }

        public static void exercise_3()
        {
            int a, b;
            do
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            } while (a > b);
            int count = a;
            for (int i = a; i <= b; i++)
            {
                for(int j = 0; j < a; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                a++;
            }
        }

        public static void exercise_4()
        {
            int n = int.Parse(Console.ReadLine());
            string str = n.ToString();

            char[] array = str.ToCharArray();
            Array.Reverse(array);
            int reverse_str = int.Parse(new string(array));
            Console.WriteLine(reverse_str);
        }

    }
}



