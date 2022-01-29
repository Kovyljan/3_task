using System;

namespace _3._2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние до точки");
            Console.Write("A = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите расстояние до точки"); 
            Console.Write("B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите расстояние до точки");
            Console.Write("C = ");
            int C = Convert.ToInt32(Console.ReadLine());

            int distance_1, distance_2;
            distance_1 = Math.Abs(B - A);
            distance_2 = Math.Abs(C - A);

            if (A == B & B == C)
            {
                Console.WriteLine("Точки A, B и C совпадают");
                Console.ReadKey();
            }

            else if (distance_1 == distance_2)
            {
                Console.WriteLine("AB = BC");
                Console.ReadKey();
            }
            else if (B == C)
            {
                Console.WriteLine("Точки B и C совпадают");
                Console.ReadKey();
            }           
            else if (A == B)
            {
                Console.WriteLine("Точки A и B совпадают");
                Console.ReadKey();
            }
            else if (A == C)
            {
                Console.WriteLine("Точки A и C совпадают");
                Console.ReadKey();
            }
            else if (distance_1 > distance_2)
            {
                Console.WriteLine("AB > BC, BC = {0}", distance_2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("AB < BC, AB = {0}", distance_1);
                Console.ReadKey();
            }



        }
    }
}
