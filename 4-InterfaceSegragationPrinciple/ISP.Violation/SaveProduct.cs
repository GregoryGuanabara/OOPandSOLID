using System;

namespace ISP.Violation
{
    public class SaveProduct : IPersintence
    {
        public void Save()
        {
            Console.WriteLine("Save");
        }

        /// <summary>
        // This method is implemented because it is specified in a generic interface, not being necessary to use it in this class
        /// </summary>
        /// <param name="emailAdress"></param>
        public void SendEmail(string emailAdress)
        {
            return;
        }

        public bool Validate()
        {
            //Validation
            return true;
        }
    }
}