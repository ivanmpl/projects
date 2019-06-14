using System;
using System.Collections.Generic;
using System.IO;
using Models;

namespace BankEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating bank account instance
            BankAccount acc = new BankAccount("Jack Powers", 500);
            // Testing class functionality
            System.Console.WriteLine(acc.Balance);
            System.Console.WriteLine(acc.Owner);
            System.Console.WriteLine(acc.AccountNumber);
            // Printing account history
            System.Console.WriteLine(acc.GetAccountHistory());

            // Create new bank accounts from txt file
            var accList = ReadFromFile("sampleAccounts.txt");

            foreach (var item in accList)
            {
                System.Console.WriteLine(item);
            }

            /* 
            try
            {
                var invalidAcc = new BankAccount("Error", -500);
            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Console.WriteLine("Invalid bank account with negative balance ");
                System.Console.WriteLine(e.ToString());
            }*/

        }

        static List<string> ReadFromFile(string file)
        {
            string line;
            List<string> strList = new List<string>();
            using (var reader = File.OpenText(file))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    strList.Add(line);
                }
            }
            return strList;
        }



    }
}
