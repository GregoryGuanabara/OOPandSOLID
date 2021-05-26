using System;

namespace LSP.Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Base Class: ");

            var account = new Account();
            account.Balance = 100;
            account.Withdraw(250);
            
            Console.WriteLine($"Account Balance {account.Balance}");
            
            Console.WriteLine();
            
            Console.WriteLine("Using Derived Class: ");
            var account1 = new SavingsAccount();
            account1.Balance = 100;
            account1.Withdraw(250);

            Console.WriteLine($"Account Balance {account1.Balance}");

            Console.ReadKey();

        }
    }
}
