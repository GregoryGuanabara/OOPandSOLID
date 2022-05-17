namespace LSP.Violation
{
    public class SavingsAccount : Account
    {
        #region Public Methods

        public override void Withdraw(double value)
        {
            if (Balance > value)
                Balance -= value;
        }

        #endregion Public Methods
    }
}