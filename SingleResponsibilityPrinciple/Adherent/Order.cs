using System;

namespace Adherent
{
    public class Order
    {
        private ILogger _logger;
        private SendEmail _SendEmail;

        public Order()
        {
            _logger = new RegisterLog();
            _SendEmail = new SendEmail();
        }

        #region Public Properties

        public DateTime Date { get; set; }
        public long Quantity { get; set; }

        #endregion Public Properties

        #region Public Methods

        public void CreateOrder()
        {
            try
            {
                _logger.LogInfo("Order Created " + DateTime.Now);
                
                _SendEmail.EmailFrom = "email@email.com";
                _SendEmail.EmailTo = "email@email.com";
                _SendEmail.EmailSubject = "SRP";
                _SendEmail.EmailBody = "Test";

                _SendEmail.Send();

            }
            catch (Exception ex)
            {
                _logger.LogInfo("Error on Create Order : " + ex.Message);
            }
        }

        public void DeleteOrder()
        {
            try
            {
                _logger.LogInfo("Order deleted " + DateTime.Now);
            }
            catch (Exception ex)
            {
                _logger.LogInfo("Error on delete Order : " + ex.Message);
            }
        }

        #endregion Public Methods
    }
}