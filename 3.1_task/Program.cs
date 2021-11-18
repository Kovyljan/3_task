using System;

namespace _3._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины прямоугольника");
            Console.Write("X1 = ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1 = ");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины прямоугольника");
            Console.Write("X2 = ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2 = ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты третей вершины прямоугольника");
            Console.Write("X3 = ");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y3 = ");
            int Y3 = Convert.ToInt32(Console.ReadLine());

            int X4, Y4;

            if (X1 == X2)
            {
                X4 = X3;
            }
            else if (X1==X3)
            {
                X4 = X2;
            }
            else
            {
                X4 = X1;
            }

            if (Y1 == Y2)
            {
                Y4 = Y3;
            }
            else if (Y1 == Y3)
            {
                Y4 = Y2;
            }
            else
            {
                Y4 = Y1;
            }


            if ((X1-X2 ==0|| X1-X3==0 || X2 - X3==0) && (Y1-Y2==0 || Y1 - Y3==0 || Y2 - Y3==0))
            {
                Console.WriteLine("X4 = {0}, Y4 = {1}", X4, Y4);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Стороны прямоугольника не параллельны координатным осям");
                Console.ReadLine();
            }


            
        }
    }
}
