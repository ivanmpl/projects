using System;
using System.Collections.Generic;

/*
write a program to caluculate and print the series of Xth powers of 2,where 0<=x<=10(1,2,4,8,16….)
without using arithematic operators or mathematiacal functions(i.e,*,/,+,-,methods of  system.
Math are not allowed)
 */


namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the nth powers of 2 to display: ");
            System.Console.Write("Where 0 <= n >= 10: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            if (n >= 0 && n <= 10)
            {
                GetNthPowers(2, n);
            }
        }

        public static void GetNthPowers(int power, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    System.Console.WriteLine(power >> 1);
                }

                System.Console.WriteLine(power);
                power = power << 1;
            }
        }
    }
}
