using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{

    public class BankAccount
    {
        private readonly int AccountNumber;
        public int accountnumber
        {
            get { return AccountNumber; }
        }
        private string AccountHolderName;
        public string accountholdername
        {
            get { return AccountHolderName; }
            set { AccountHolderName = value; }
        }
        private double Balance;



        public BankAccount(string name, int num)
        {
            this.AccountHolderName = name;
            this.AccountNumber = num;
            this.Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}.\nNew balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than 0.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}.\nNew balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

    }
}
