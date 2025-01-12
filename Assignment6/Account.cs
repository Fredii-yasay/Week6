using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Account
    {
        private string _accountholder { get; set; }
        private double _amount { get; set; }

        public Account(string accountholder)
        {
            this._accountholder = accountholder;
        }
        public void Deposit (double amount)
        {
            Console.WriteLine("Deposit successful");
            this._amount = amount;
            DisplayInfo();
        }

        public void LogTransaction (string message)
        {
            Console.WriteLine (message);
        }

        public void DisplayInfo()
        {
            LogTransaction(this._accountholder);
            Console.WriteLine($"Amount: {this._amount}");
        }
    }
}
