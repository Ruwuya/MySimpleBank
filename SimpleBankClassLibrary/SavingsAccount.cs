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
        public decimal InterestRate { get; set; }

        public void Deposit(decimal amount)
        {
            // Ensure you cannot deposit a negative amount
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            // Ensure you cannot withdraw more than the current balance
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

        public void AddInterest()
        {
            // Simple interest calculation
            Balance += Balance * InterestRate;
        }

        // Show current balance, account number and adding a interest rate
        public void GetBalance()
        {
            InterestRate = 0.02m; // 2% interest rate whenever balance is checked for simplicity
            Balance += InterestRate; // Adding interest to the balance
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
        }

    }
}
