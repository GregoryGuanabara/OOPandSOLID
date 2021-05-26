using System;

namespace Decoupling_Code
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            var registerOccurrencyOnConsole = new RegisterOccurrency(new RegisterOnConsole());
            var registerOccurrencyOnFile = new RegisterOccurrency(new RegisterOnFile(@"teste.txt"));

            registerOccurrencyOnConsole.Register("Console Log");
            registerOccurrencyOnFile.Register("File Log");

            Console.ReadKey();
        }

        #endregion Private Methods
    }
}