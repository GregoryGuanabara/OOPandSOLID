using System;

namespace Decoupling_Code
{
    internal class RegisterOccurrency
    {
        #region Private Fields

        private readonly IRegister _register;

        #endregion Private Fields

        #region Public Constructors

        public RegisterOccurrency(IRegister register)
        {
            _register = register;
        }

        #endregion Public Constructors

        #region Public Methods

        public void Register(string message)
        {
            _register.RegisterInfo($"{message} : {DateTime.Now}");
        }

        #endregion Public Methods
    }
}