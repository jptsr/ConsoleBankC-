using System;
using SpaceClient;
using Bank;
using Questions;

namespace SpaceCreate
{
    class Create
    {
        public int[] create()
        {
            int id = this.createClient();
            int[] data = this.createAccount(id);
            return data;
        }

        public int createClient()
        {
            Console.WriteLine("What is your name ?");
            string name = Console.ReadLine();
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            Client client = new Client(0, name, date);
            return client.ClientId;
            // insert in db
        }

        public int[] createAccount(int clientId)
        {
            Console.WriteLine("What is your balance account ?");
            int amount = Int32.Parse(Console.ReadLine());
            BankAccount bank = new BankAccount(clientId, amount);
            int[] data = new int[] { bank.IdClient, bank.AccountBalance };
            return data;
            // insert in db
        }
    }
}