/* ATM emulator program with simple functionality */

using System;

namespace Exercise7
{
    public class ATM
    {
        private decimal balance = 0;
        private int pin = 1234;

        public bool PromptPin()
        {
            System.Console.Write("Please Enter Pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            if (this.pin == pin)
                return true;
            else
                System.Console.WriteLine("Invalid Pin");
            return false;
        }

        public void CheckBalance()
        {
            System.Console.WriteLine("Balance: " + balance);
        }

        public void CashWithdrawal()
        {
            System.Console.Write("Enter Amount to Withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (balance >= amount)
                balance -= amount;
            else
                System.Console.WriteLine("Invalid Amount");
        }

        public void CashDeposit()
        {
            System.Console.Write("Enter Amount to Deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            balance += amount;
        }

        public void PrintServices()
        {
            System.Console.WriteLine("***Welcome to ATM Services***");
            System.Console.WriteLine("1. Check Balance");
            System.Console.WriteLine("2. Withdraw Cash");
            System.Console.WriteLine("3. Deposit Cash");
            System.Console.WriteLine("4. Quit");
        }

        public bool SelectService()
        {
            System.Console.Write("Select Service: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    CheckBalance();
                    return true;
                case 2:
                    CashWithdrawal();
                    return true;
                case 3:
                    CashDeposit();
                    return true;
                case 4:
                    System.Console.WriteLine("Goodbye");
                    return false;
                default:
                    System.Console.WriteLine("Invalid Response");
                    return true;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ATM a1 = new ATM();
            if (a1.PromptPin())
            {
                a1.PrintServices();
                while (a1.SelectService()) ;
            }
        }
    }
}
