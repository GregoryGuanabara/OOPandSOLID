using System;

namespace ISP.Violation
{
    public class SaveClient : IPersintence
    {
        public void Save()
        {
            Console.WriteLine("Save");
        }

        public void SendEmail(string emailAdress)
        {
            Console.WriteLine("Send Wellcome Email");
        }

        public bool Validate()
        {
            //Validate
            return true;
        }
    }
}