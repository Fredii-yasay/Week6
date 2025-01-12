using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class BankAccount
    {
        private string AccountNumber {  get; set; }
        private double Balance { get; set; }

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine("Deposit Successful");
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
            Console.WriteLine("Withdrawal Successful");
        }

        public void DisplayAccount()
        {
            Console.WriteLine($"\nAccount Details\n" +
                $"accountNumber = {this.AccountNumber}\n" +
                $"Balance = {this.Balance}");
        }
    }
}
