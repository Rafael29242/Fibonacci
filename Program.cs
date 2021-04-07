using System;

namespace Ch5_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 0, fib2 = 1, fib3 = 0;
            Console.WriteLine("{0}\n{1}", fib1, fib2);

            for(int fib = 2; fib < 20; fib++)
            {
                fib3 = fib1 + fib2;
                Console.WriteLine("{0}", fib3);

                fib1 = fib2;
                fib2 = fib3;
            }
        }
    }
}
