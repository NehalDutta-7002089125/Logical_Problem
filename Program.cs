using System;

namespace squareroot
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Enter a number : ");

            double c = Convert.ToDouble(Console.ReadLine());
            
            double t = c;  
            
            double EPSILON = 1e-15;

            while (Math.Abs(t * t - c) > EPSILON) 

            {
                t = (c / t + t) / 2.0; 
            }
            Console.WriteLine("The square root of c is :"+t);
        }
    }
}
