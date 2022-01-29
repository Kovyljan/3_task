using System;

namespace _3._4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < 100 || N > 999)
            {
                Console.WriteLine("Ошибка!");
            }
            else
            {
                int N_1 = N / 100;
                int N_2_1 = (N % 100)/10;
                double N_2_2 = (N % 100) % 10;
                int N_3 = (N % 100) % 10;

                switch (N_1)
                {
                    case 1:
                        {
                            Console.Write("Сто");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Двести");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Триста");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Четыреста");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Пятсот");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Шестьсот");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Семьсот");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Восемьсот");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("Девятьсот");
                            break;
                        }
                    default:
                        {
                            Console.Write("");
                        }
                        break;
                }

                switch (N_2_1)
                {
                    case 2:
                        {
                            Console.Write(" двадцать");
                            break;
                        }
                    case 3:
                        {
                            Console.Write(" тридцать");
                            break;
                        }
                    case 4:
                        {
                            Console.Write(" сорок");
                            break;
                        }
                    case 5:
                        {
                            Console.Write(" пятьдесят");
                            break;
                        }
                    case 6:
                        {
                            Console.Write(" шестьдесят");
                            break;
                        }
                    case 7:
                        {
                            Console.Write(" семьдесят");
                            break;
                        }
                    case 8:
                        {
                            Console.Write(" восемьдесят");
                            break;
                        }
                    case 9:
                        {
                            Console.Write(" девяносто");
                            break;
                        }
                    default:
                        {
                            Console.Write("");
                        }
                        break;
                }

                if (N_2_1 == 1)
                {
                    switch (N_2_2)
                    {
                        case 1:
                            {
                                Console.Write(" одинадцать");
                                break;
                            }
                        case 2:
                            {
                                Console.Write(" двенадцать");
                                break;
                            }
                        case 3:
                            {
                                Console.Write(" тринадцать");
                                break;
                            }
                        case 4:
                            {
                                Console.Write(" четырнадцать");
                                break;
                            }
                        case 5:
                            {
                                Console.Write(" пятнадцать");
                                break;
                            }
                        case 6:
                            {
                                Console.Write(" шестнадцать");
                                break;
                            }
                        case 7:
                            {
                                Console.Write(" семьнадцать");
                                break;
                            }
                        case 8:
                            {
                                Console.Write(" восемьнадцать");
                                break;
                            }
                        case 9:
                            {
                                Console.Write(" девятнадцать");
                                break;
                            }
                        default:
                            {
                                Console.Write("");
                            }
                            break;
                    }
                }
                else
                {
                    switch (N_3)
                    {
                        case 1:
                            {
                                Console.Write(" один");
                                break;
                            }
                        case 2:
                            {
                                Console.Write(" два");
                                break;
                            }
                        case 3:
                            {
                                Console.Write(" три");
                                break;
                            }
                        case 4:
                            {
                                Console.Write(" четыре");
                                break;
                            }
                        case 5:
                            {
                                Console.Write(" пять");
                                break;
                            }
                        case 6:
                            {
                                Console.Write(" шесть");
                                break;
                            }
                        case 7:
                            {
                                Console.Write(" семь");
                                break;
                            }
                        case 8:
                            {
                                Console.Write(" восемь");
                                break;
                            }
                        case 9:
                            {
                                Console.Write(" девять");
                                break;
                            }
                        default:
                            {
                                Console.Write("");
                            }
                            break;
                    }
                }


            }

            Console.ReadKey();
        }
    }
}
