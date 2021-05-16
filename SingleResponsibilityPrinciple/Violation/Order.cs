using System;
using System.IO;
using System.Net.Mail;

namespace Single_Responsibility_Principle.Problem
{
    public class Order
    {
        #region Public Properties

        public DateTime Date { get; set; }
        public long Quantity { get; set; }

        #endregion Public Properties

        #region Public Methods

        public void CreateOrder()
        {
            try
            {
                // Codigo para incluir o pedido
                // Após incluir então envia o email
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                SendOrderEmail(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"ErrorLog.txt", ex.ToString());
            }
        }

        public void SendOrderEmail(MailMessage mailMessage)
        {
            try
            {
                // Código para enviar configurar
                // email e enviar o email do pedido
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"ErrorLog.txt", ex.ToString());
            }
        }

        public void DeleteOrder()
        {
            try
            {
                //Codigo para deletar o pedido gerado
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"ErrorLog.txt", ex.ToString());
            }
        }

        #endregion Public Methods
    }
}