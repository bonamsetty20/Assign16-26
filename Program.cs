using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Deva", 764);
           

            Console.WriteLine($"details of account 1 :\nAccount holder name :{account.accountholdername}\nAccount number : {account.accountnumber}");
            Console.WriteLine("Enter the Amount you want to deposit ");
            account.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter how much amount you want to with draw");
            account.Withdraw(double.Parse(Console.ReadLine())); 
            Console.ReadKey();
        }
    }
}
