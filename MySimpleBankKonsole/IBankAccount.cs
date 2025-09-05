using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleBankKonsole
{
    public interface IBankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void GetBalance();
    }
}
