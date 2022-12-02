using System;

namespace Reverseno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reverse =0, R, a;

            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());

            while (a >0)
            {

                R = a %10;

                reverse = reverse *10 +R;

                a /= 10;

            }

            Console.WriteLine("The number has been reversed "+reverse);
        }
    }
}
