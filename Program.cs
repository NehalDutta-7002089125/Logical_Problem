using System;

namespace Perfectno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Console.WriteLine("Enter a number");

            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < b; i++)
            {


                if (b % i == 0)
                {
                    a = a + i;
                }
            }

            if (a == b)

            {
                Console.WriteLine(b+ " is a pefect number");

            }
            else

            {
                Console.WriteLine(b+ " is not a perfect number");

            }
        }
    }
}
