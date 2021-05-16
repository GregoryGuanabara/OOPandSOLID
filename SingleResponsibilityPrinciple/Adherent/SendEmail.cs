using System;

namespace Adherent
{
    public class SendEmail
    {
        private readonly ILogger _logger;

        public SendEmail()
        {
            _logger = new RegisterLog();
        }

        #region Public Properties

        public string EmailBody { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string EmailTo { get; set; }

        #endregion Public Properties

        #region Public Methods

        public void Send()
        {
            _logger.LogInfo($"Email sended : To: {EmailTo}, From: {EmailFrom}, On: {DateTime.Now}");
        }

        #endregion Public Methods
    }
}