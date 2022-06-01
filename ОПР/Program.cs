using System;
namespace opr
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b ");
            int b = int.Parse(Console.ReadLine());
            Program random = new Program();
            for(int i = 0; i < 100; i++)
            {
                Console.Write(random.Random(a, b + 1));
                Console.Write(", ");
            }
        }
        public int Random(int a, int b)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                rand.Next(a, b);

            }
            return rand.Next(a, b);
        }
    }
}
