/* reverse a string program */

using System;

namespace Exercise3
{
    class Program
    {
        public static string ReverseString(string str)
        {
            // convert string to character array
            char[] charArr = str.ToCharArray();
            // use array class method to reverse chars
            Array.Reverse(charArr);
            // create string using string class constructor
            return new string(charArr);
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a string to reverse: ");
            string str = Console.ReadLine();
            System.Console.WriteLine($"Reversed string: {ReverseString(str)}");
        }
    }
}
