namespace LSP.Adherent
{
    public class PersonalAccount : Account
    {
        public override void Withdraw(double value)
        {
            Balance -= value;
        }
    }
}