using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposit successful!");
            }
            else
            {
                Console.WriteLine("Invalid amount for deposit.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful!");
            }
            else
            {
                Console.WriteLine("Invalid amount for withdrawal.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}


