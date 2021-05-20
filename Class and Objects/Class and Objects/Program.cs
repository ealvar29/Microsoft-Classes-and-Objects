﻿using System;

namespace Class_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Testing New Account", 1000);

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            foreach (var item in account._allTransactions)
            {
                Console.WriteLine(item.Notes);
            }
        }
    }
}
