/* display n amount of rows of diamonds program */

using System;

namespace Exercise6
{
    class Program
    {
        static void PrintDiamonds(int rows)
        {
            int i, j, k, n, space = rows - 1;

            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < space; j++)
                {
                    System.Console.Write(" ");
                }

                space--;

                for (j = 0; j <= 2 * i; j++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine();
            }
            
            space = 1;

            for (k = rows-2; k >= 0; k--)
            {
                
                for (n = 0; n < space; n++)
                {
                    System.Console.Write(" ");
                }

                space++;

                for (n = 2*k; n >= 0; n--)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows to display: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            PrintDiamonds(rows);
        }
    }
}
