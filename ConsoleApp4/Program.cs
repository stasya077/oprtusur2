using System;
namespace Currently
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            Random rand = new Random();
            for (int i = 0; i < k; i++)
            {
                array[i] = rand.Next(1, 101);
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Random rand1 = new Random();
            for (int i = 0; i < array.Length; i++)
            {

                int j = rand1.Next(array.Length);
                int tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}
