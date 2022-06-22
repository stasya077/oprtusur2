using System;
namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    if (n % i == 0)
                        k++;
                }
            }
            Console.WriteLine(k);
        }
    }
}