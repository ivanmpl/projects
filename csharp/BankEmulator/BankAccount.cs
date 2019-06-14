using System;
using System.Collections.Generic;

namespace Models
{
    public class BankAccount
    {
        public BankAccount(string name, decimal balance)
        {
            this.AccountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;

            Deposit(balance, DateTime.Now, "intial balance");
        }
        private static int accountNumberSeed = 000001;
        public string AccountNumber { get; }
        public string Owner { get; set; }
        private List<Transaction> transactionLedger = new List<Transaction>();

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var trans in transactionLedger)
                {
                    balance += trans.Amount;
                }

                return balance;
            }
        }

        public void Deposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
            }

            Transaction deposit = new Transaction(amount, date, note);
            transactionLedger.Add(deposit);
        }

        public void Withdraw(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
            }

            if ((Balance - amount) < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Insufficient Funds for withdrawl");
            }

            var withdrawal = new Transaction(-amount, date, note);
            transactionLedger.Add(withdrawal);

        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Date\tTime\tNote");
            foreach (var trans in transactionLedger)
            {
                report.Append($"{trans.Date.ToShortDateString()}\t{trans.Amount}\t{trans.Note}");
            }

            return report.ToString();
        }
    }

}