using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {

        static void PromptValues(ref int val1, ref int val2)
        {
            System.Console.Write("Enter Value A: ");
            val1 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter Value B: ");
            val2 = Convert.ToInt32(System.Console.ReadLine());
        }

        static int PerfectSquare(int A, int B)
        {

            List<int> perfectSquareList = new List<int>();

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j * j == i)
                        perfectSquareList.Add(i);
                }
            }

            return perfectSquareList.Count;
        }

        static void Main(string[] args)
        {
            int aVal = 0, bVal = 0;
            PromptValues(ref aVal,ref bVal);
            System.Console.WriteLine("Number of Perfect Squares: " + PerfectSquare(aVal, bVal));
        }
    }
}
