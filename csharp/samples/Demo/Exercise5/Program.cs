/* binary tree generator for n amount of rows program */

using System;

namespace Exercise5
{
    class Program
    {
        public static void DisplayBinaryTree(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("0");
                    else
                        Console.Write("1");

                    Console.Write(" ");
                }

                System.Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows in binary tree: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            DisplayBinaryTree(rows);
        }
    }
}
