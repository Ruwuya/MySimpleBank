using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleBankKonsole
{
    public class SavingsAccount : IBankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
            }
            Balance += amount;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
            Balance -= amount;
        }
    }
}
