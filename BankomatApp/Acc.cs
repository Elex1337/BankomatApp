using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatApp
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public Client Owner { get; private set; }

        public Account(int accountNumber, decimal initialBalance, Client owner)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            Owner = owner;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
