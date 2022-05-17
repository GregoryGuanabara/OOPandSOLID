using System;

namespace SRP.Adherent
{
    public class RegisterLog : ILogger
    {
        #region Public Methods

        public void LogInfo(string info)
        {
            Console.WriteLine(info);
        }

        #endregion Public Methods
    }
}