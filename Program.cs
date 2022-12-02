using System;

namespace MonthlyPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  P, Y, R, n, r, Payment;

            Console.WriteLine("Enter Loan Amount : ");

            P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("No. of years to pay the principle amount : ");

            Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate of interest : ");

            R = Convert.ToDouble(Console.ReadLine());

            n = 12 * Y; r = R / (12 * 100);

            Payment = (P * r) / (1 - Math.Pow(1 + r, -n));

            Console.WriteLine(Payment);

        }
    }
}
