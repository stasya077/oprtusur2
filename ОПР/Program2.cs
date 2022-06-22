using System;
namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1 = 0;
            double R2 = 0;
            int k = 0;
            Console.Write("Введите величину первого сопротивления ");
            R1 = double.Parse(Console.ReadLine());
            Console.Write("Введите величину второго сопротивления ");
            R2 = double.Parse(Console.ReadLine());
            double R = 0;
            Console.WriteLine("Выберите тип соединения");
            Console.Write("1 – последовательное      ");
            Console.Write("2 – параллельное");
            Console.WriteLine();
            k = int.Parse(Console.ReadLine());
            if (k == 1)
            {
                R = R1 + R2;
            }
            if (k == 2)
            {
                R = (R1 * R2) / (R1 + R2);
            }
            Console.Write(R);
        }
    }
}