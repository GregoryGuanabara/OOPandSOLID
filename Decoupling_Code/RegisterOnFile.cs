using System.IO;

namespace Decoupling_Code
{
    internal class RegisterOnFile : IRegister
    {
        #region Public Constructors

        public RegisterOnFile(string path)
        {
            _path = path;
        }

        #endregion Public Constructors

        #region Private Properties

        private string _path { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void Log(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
                streamWriter.WriteLine(message);
        }

        public void RegisterInfo(string message)
        {
            Log(message);
        }

        #endregion Public Methods
    }
}