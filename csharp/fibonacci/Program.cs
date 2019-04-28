using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get number of sequences from std input
            Console.Write("Enter Number of Sequences for Fibonacci: ");
            var number_sequence = Console.ReadLine();

            // Parse for valid integer            
            if (int.TryParse(number_sequence, out int sequence_number))
            {
                // adds extra loop O(n)
                for (int i = 0; i < sequence_number; i++)
                {
                    Console.WriteLine($"{i + 1}: {FibonacciNumber(i)}");
                }
            }
            else
            {
                Console.WriteLine($"{number_sequence} is not a number");
            }
        }

        static int FibonacciNumber(int n)
        {
            // create list of the first two values
            List<int> FibonacciList = new List<int> { 1, 1 };

            // add to next values in list to n sequence
            for (int i = 0; i < n; i++)
            {
                int previous = FibonacciList[FibonacciList.Count - 1];
                int previous2 = FibonacciList[FibonacciList.Count - 2];
                FibonacciList.Add(previous + previous2);
            }

            return FibonacciList[n];
        }
    
        static int FibonacciNumber2(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                // save a value to temp
                tmp = a;
                // set next value in sequence to a
                a = b;
                // add previous value to current value in sequence
                b += tmp;
            }

            return a;
        }

    }
}