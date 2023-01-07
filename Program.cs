using System;

namespace Fabonacchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int a = 0, b = 1, c;
           Console.WriteLine(a);
            Console.WriteLine(b);

               for (int i = 0; i <10; i++)
               {
                c = a + b;
                a++;
                b++;
             
                Console.WriteLine(c);
               }
        }
    }
}
