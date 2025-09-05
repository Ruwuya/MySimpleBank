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
            // Validate deposit amount is positive
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            // Validate withdrawal amount is positive and does not exceed balance
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


        public decimal AddInterest()
        {
            // Simple interest calculation
            InterestRate = 0.05m; // 5% interest rate
            decimal interest = Balance * InterestRate / 100;
            Balance += interest;
            return interest;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
            AddInterest(); // Automatically add interest when checking balance
        }
    }
}
