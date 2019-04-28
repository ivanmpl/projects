using System;
using System.Collections.Generic;

namespace Exercise3
{

    class Account
    {
        private DateTime date;
        private string description;
        private string category;
        private double amount;

        Account()
        {
            PromptData();
        }

        public void PromptData()
        {
            System.Console.WriteLine("Enter Account Date: ");
            date = Convert.ToDateTime(Console.ReadLine());
            System.Console.WriteLine("Enter Account Description: ");
            description = Console.ReadLine();
            System.Console.WriteLine("Enter Account Category: ");
            category = Console.ReadLine();
            System.Console.WriteLine("Enter Account Amount: ");
            amount = Convert.ToDouble(Console.ReadLine());
        }

    }



    class HouseholdAccounts
    {
        static void Main(string[] args)
        {

            List<Account> acc = new List<Account>(10000);

        }
    }
}
