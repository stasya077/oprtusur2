using System;
namespace opr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Количество попыток: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int komp = random.Next(1, max);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите своё число: ");
                int t = int.Parse(Console.ReadLine());
                if (i == n - 1)
                {
                    Console.WriteLine("Попытки закончились");
                    break;
                }
                if (komp != t)
                {
                    if (komp < t)
                        Console.WriteLine("Число меньше");
                    else
                        Console.WriteLine("Число больше");
                }
                else
                {
                    Console.WriteLine("Вы угадали");
                    break;
                }
            }
        }
    }
}