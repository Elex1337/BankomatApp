using BankomatApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatApp
{
    public class Bank
    {
        private static int accountNumberCounter = 1000;

        public static Account OpenAccount(Client client)
        {
            int accountNumber = accountNumberCounter++;
            Account newAccount = new Account(accountNumber, 0, client);
            return newAccount;
        }
    }
}