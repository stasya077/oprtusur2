using System;
namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Запоните массив");
            for (int i = 0; i < n; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите номер элемента");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(mas[k - 1]);
        }
    }
}