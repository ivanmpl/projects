using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Number of Sequences for Fibonacci: ");
            var seq_input = Console.ReadLine();            
            if (int.TryParse(seq_input, out int seq_output))
            {
                for (int i = 0; i < seq_output; i++)
                {
                    Console.WriteLine($"{i + 1}: {FibonacciNumber(i)}");
                }

            }
            else
            {
                Console.WriteLine($"{seq_input} is not a number");
            }


        }

        static int FibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }

    }
}