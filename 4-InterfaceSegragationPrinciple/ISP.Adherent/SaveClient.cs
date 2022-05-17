using System;

namespace ISP.Adherent
{
    public class SaveClient : IPersintence, IEmailMessage
    {
        public void Save()
        {
            Console.WriteLine("Save");
        }

        public bool Validate()
        {
            //Validate
            return true;
        }

        public void SendEmail(string EmailAdress)
        {
            Console.WriteLine("Send Wellcome Email");
        }
    }
}
