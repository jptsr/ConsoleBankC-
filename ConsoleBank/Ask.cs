using System;
using SpaceCreate;
using Bank;

namespace Questions
{
    class Ask
    {
        public void askQuestions()
        {
            Console.WriteLine("Welcome, do you want to create an account ? y/n");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes" || answer == "YES")
            {
                Create create = new Create();
                int[] data = create.create();
                askAccount(data[0], data[1]);
            }
            else if (answer == "n" || answer == "N" || answer == "no" || answer == "No" || answer == "NO")
            {
                Console.WriteLine("alright, bye !");
            }
            else
            {
                Console.WriteLine("You didn't answer.");
                askQuestions();
            }
        }

        public void askAccount(int id, int amount)
        {
            Console.WriteLine("Do you want to have a look on your account ? y/n");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes" || answer == "YES")
            {
                askTransaction(id, amount);
            }
            else if (answer == "n" || answer == "N" || answer == "no" || answer == "No" || answer == "NO")
            {
                Console.WriteLine("alright, goodbye !");
            }
            else
            {
                Console.WriteLine("You didn't answer.");
                askAccount(id, amount);
            }
        }

        public void askTransaction(int id, int amount)
        {
            Console.WriteLine("Do you want to check your balance or make a move ? check/transaction");
            string answer = Console.ReadLine();
            BankAccount bank = new BankAccount(id, amount);

            if (answer == "check")
            {
                bank.CheckBalance();
            }
            else if (answer == "transaction")
            {
                Console.WriteLine("Do you want to make a deposit or withdraw money ? deposit/withdrawal");
                string answer_bis = Console.ReadLine();

                if (answer_bis == "deposit")
                {
                    Console.WriteLine("How much do you want to add to your account ?");
                    int deposit = Int32.Parse(Console.ReadLine());
                    bank.Deposit(deposit);
                }
                else if (answer_bis == "withdraw")
                {
                    int account_amount = bank.CheckBalance();

                    Console.WriteLine("What sum do you want to withdraw ?");
                    int sum = Int32.Parse(Console.ReadLine());

                    if (account_amount > sum || account_amount == sum)
                    {
                        bank.Withdraw(sum);
                        Console.WriteLine("Thanks for your visit.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough on your account.");
                    }
                }
                else
                {
                    Console.WriteLine("You didn't answer.");
                    askTransaction(id, amount);
                }
            }
            else
            {
                Console.WriteLine("You didn't answer correctly.");
                askTransaction(id, amount);
            }
        }
    }
}