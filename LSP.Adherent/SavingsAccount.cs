using System;

namespace LSP.Adherent
{
    public class SavingsAccount : Account
    {
        public override void Withdraw(double value)
        {
            if (Balance > value)
                Balance -= value;
        }
    }
}