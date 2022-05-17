using System;

namespace DIP.Adherent
{
    public class DbConnection : IDBConnection
    {
        public void connect()
        {
            Console.WriteLine("Connected to DB");
        }
    }
}