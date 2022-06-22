using System;
namespace opr
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите площадь: ");
            double S = double.Parse(Console.ReadLine());
            for (int i = 1; i < 999; i++)
            {
                for (int j = 1; j < 999; j++)
                {
                    double g = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                    double SS = (i * j) * 0.5;
                    if (g == Math.Truncate(g) && (SS < S))
                    {
                        Console.WriteLine($"a={i}, b={j}, c={g}, S={SS}");
                    }
                }
            }
        }
    }
}
