using System;
namespace Currently
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            string str = n.ToString();
            int[] b = new int[str.Length];
            Console.WriteLine("Введите число x ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y ");
            int y = int.Parse(Console.ReadLine());
            int i = 0;
            int t = 0;
            int k = 0;
            while (i != str.Length)
            {
                b[i] = int.Parse(str[i].ToString());
                if (b[i] == x)
                    t++;
                if (b[i] == y)
                    k++;
                i++;
            }
            Console.WriteLine(t);
            Console.WriteLine(k);
        }
    }
}