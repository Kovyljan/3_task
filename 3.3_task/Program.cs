using System;

namespace _3._3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст от 20 до 69");                
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 20 || age > 69)
            {
                Console.WriteLine("Ошибка!");
            }
            else
            {
                int age_1 = age / 10;
                int age_2 = age % 10;

                switch (age_1)
                {
                    case 2:
                        {
                            Console.Write("Двадцать");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Тридцать");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Сорок");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Пятьдесят");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Шестьдесят");
                            break;
                        }
                    default:
                        {
                            Console.Write("");
                        }
                        break;
                }

                switch (age_2)
                {
                    case 0:
                        {
                            Console.Write(" лет");
                            break;
                        }
                    case 1:
                        {
                            Console.Write(" один год");
                            break;
                        }
                    case 2:
                        {
                            Console.Write(" два года");
                            break;
                        }
                    case 3:
                        {
                            Console.Write(" три года");
                            break;
                        }
                    case 4:
                        {
                            Console.Write(" четыре года");
                            break;
                        }
                    case 5:
                        {
                            Console.Write(" пять лет");
                            break;
                        }
                    case 6:
                        {
                            Console.Write(" шесть лет");
                            break;
                        }
                    case 7:
                        {
                            Console.Write(" семь лет");
                            break;
                        }
                    case 8:
                        {
                            Console.Write(" восемь лет");
                            break;
                        }
                    case 9:
                        {
                            Console.Write(" девять лет");
                            break;
                        }
                    default:
                        {
                            Console.Write("");
                        }
                        break;
                }


            }

            Console.ReadKey();
        }
    }
}
