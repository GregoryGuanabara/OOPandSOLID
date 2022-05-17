using System;

namespace ISP.Adherent
{
    public class SaveProduct : IPersintence
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
    }
}