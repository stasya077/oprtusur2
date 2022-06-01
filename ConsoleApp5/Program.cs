using System;
namespace opr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            DateTime date1 = new DateTime(year, 1, 31);
            Console.WriteLine(Thursday(date1));
            DateTime date2 = new DateTime(year, 2, 28);
            Console.WriteLine(Thursday(date2));
            DateTime date3 = new DateTime(year, 3, 31);
            Console.WriteLine(Thursday(date3));
            DateTime date4 = new DateTime(year, 4, 30);
            Console.WriteLine(Thursday(date4));
            DateTime date5 = new DateTime(year, 5, 31);
            Console.WriteLine(Thursday(date5));
            DateTime date6 = new DateTime(year, 6, 30);
            Console.WriteLine(Thursday(date6));
            DateTime date7 = new DateTime(year, 7, 31);
            Console.WriteLine(Thursday(date7));
            DateTime date8 = new DateTime(year, 8, 31);
            Console.WriteLine(Thursday(date8));
            DateTime date9 = new DateTime(year, 9, 30);
            Console.WriteLine(Thursday(date9));
            DateTime date10 = new DateTime(year, 10, 31);
            Console.WriteLine(Thursday(date10));
            DateTime date11 = new DateTime(year, 11, 30);
            Console.WriteLine(Thursday(date11));
            DateTime date12 = new DateTime(year, 12, 31);
            Console.WriteLine(Thursday(date12));
        }
        static DateTime Thursday(DateTime data)
        {
            while (data.DayOfWeek != DayOfWeek.Thursday)
            {
                data = data.AddDays(-1);
            }
            return data;
        }
    }
}