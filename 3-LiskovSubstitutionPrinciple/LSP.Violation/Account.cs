namespace LSP.Violation
{
    public class Account
    {
        public double Balance { get; set; }

        public virtual void Withdraw(double value)
        {
            Balance -= value;
        }
    }
}