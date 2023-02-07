using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[26];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }

            for (int i = 0; i < fib.Length; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fib[i]);
            }

            Console.ReadLine();
        }
    }
}