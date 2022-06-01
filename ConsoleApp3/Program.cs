using System;
namespace opr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, 2, 3, 4 };
            Random rand = new Random();
            while (mass[0] == 1 || mass[1] == 2 || mass[2] == 3 || mass[3] == 4)
            {
                for (int i = 0; i <= 3; i++)
                {
                    int a = rand.Next(mass.Length);
                    int t = mass[i];
                    mass[i] = mass[a];
                    mass[a] = t;
                }
            }
            for (int j = 0; j < mass.Length; j++)
            {
                Console.WriteLine($"{j + 1} {mass[j]}");
            }
        }
    }
}