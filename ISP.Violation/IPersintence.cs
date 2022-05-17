namespace ISP.Violation
{
    public interface IPersintence
    {
        void Save();

        void SendEmail(string emailAdress);

        bool Validate();
    }
}