using System;

namespace Class_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Testing New Account", 1000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
    }
}
