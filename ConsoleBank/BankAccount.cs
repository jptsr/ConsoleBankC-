using System;

namespace Bank
{
    class BankAccount
    {
        private int Client;
        private int Balance;
        private int Type;

        public int IdClient {
            get { return Client; }
            set { Client = value; }
        }

        public int AccountBalance { 
            get { return Balance; }
            set { Balance = value; }    
        }

        public int TransactionType { 
            get { return Type; }
            set { Type = value; }
        }

        // constructor (must have the same name as the name class
        public BankAccount(int idClient, int accountBalance)
        {
            this.IdClient = idClient;
            this.AccountBalance = accountBalance;
        }

        public int CheckBalance()
        {
            Console.WriteLine("Account : " + AccountBalance);
            return AccountBalance;
        }

        public int Withdraw(int sum)
        {
            AccountBalance -= sum;
            Console.WriteLine("Account : " + AccountBalance);
            return AccountBalance;
        }

        public int Deposit(int amount)
        {
            AccountBalance += amount;
            Console.WriteLine("Account : " + AccountBalance);
            return AccountBalance;
        }
    }
}