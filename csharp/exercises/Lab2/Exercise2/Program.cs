using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {20,10,30,30,40,10};
            Solution sol = new Solution();
            System.Console.WriteLine(sol.GetMaxOccurence()); 
        }
    }
}
