using System;

namespace PrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, i;

            Console.Write("Enter a number : ");

            a = int.Parse(Console.ReadLine());

            for (i =2; i <a / 2; i++)

            {
                if (a % i == 0)

                {
                    Console.Write(a + "is not a Prime number.");

                }

                else

                {

                    Console.Write(a + " is a Prime number.");
                }
            }
        }
    }
}

