using System;
using System.Collections.Generic;
using System.Text;

namespace Decoupling_Code
{
    class RegisterOnConsole : IRegister
    {
        public void RegisterInfo(string message)
        {
            Console.WriteLine($"info: {message}");
        }
    }
}
