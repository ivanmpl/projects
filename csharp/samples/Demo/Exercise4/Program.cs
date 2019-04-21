/* display armstrong numbers from n to m program  */

using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        ///
        public static void DisplayArmstrong(int n, int m)
        {
            int sum = 0, temp = 0, digit = 0;

            for (int i = n; i < m; i++)
            {
                sum  = 0;
                temp = i;
                while (temp > 0)
                {
                    // get the digits for specified number by dividing with mod operator
                    // as number divided by 10 is the last digit of number
                    digit = temp % 10;
                    sum += (digit * digit * digit);
                    temp = temp / 10;
                }

                if (i == sum)
                {
                    System.Console.WriteLine(sum);
                }

            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            DisplayArmstrong(num1, num2);
        }
    }
}
