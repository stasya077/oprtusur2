using System;
namespace Program1
{
 class Program
{
    static void Main(string[] args)
    {
        double R = 0;
        double U = 0;
        Console.Write("Введите напряжение цепи ");
        U = double.Parse(Console.ReadLine());
        Console.Write("Введите сопротивление цепи ");
        R = double.Parse(Console.ReadLine());

        double I = 0;
        I = U / R;
        Console.Write(I);
    }
}
}