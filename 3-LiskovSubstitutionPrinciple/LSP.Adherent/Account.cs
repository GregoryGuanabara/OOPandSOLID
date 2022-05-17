namespace LSP.Adherent
{
    public abstract class Account
    {
        public double Balance { get; set; }

        public abstract void Withdraw(double value);
    }
}