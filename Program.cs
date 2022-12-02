using System;
using System.Globalization;

namespace Dayoffweek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MonthNum= 0, year, d, y, x, m, day;

            Console.WriteLine("Enter Year : ");

            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month : ");

            string monthName = Console.ReadLine();

            Console.WriteLine("Enter Date : ");

            d = Convert.ToInt32(Console.ReadLine());

            y = year - (14 - MonthNum) / 12;

            x = y + y / 4 - y / 100 + y / 400;

            m = MonthNum + 12 * ((14 - MonthNum) / 12) - 2;

            day = (d + x + (31 * m) / 12) % 7;

            Console.WriteLine("Day number is : " + day);

            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    break;
            }
        }
    }
}
