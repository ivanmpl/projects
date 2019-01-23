using System;

namespace repeatedString
{
    class Program
    {
        public static long repeatString(string s, long n)
        {
            long stringCount = s.Split('a').Length - 1;
            long stringLength = s.Length;

            long count = (n / stringLength) * stringCount;
            long countRemainder = n % stringLength;

            int intRemainder = (int)countRemainder;

            string remainderString = s.Substring(0, intRemainder);

            long remainderCount = remainderString.Split('a').Length - 1;

            return count + remainderCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(repeatString("aba", 10));
        }
    }
}
