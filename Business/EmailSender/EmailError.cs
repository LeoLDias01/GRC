using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Business.EmailSender
{
    public class EmailError
    {
        public static void EnviarEmailErro(string mensagemErro)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;

                string fromEmail = "azelkaari@gmail.com";
                string password = "jfgn vpqp uwxd cvjl"; // 16 caracteres
                string toEmail = "azelkaari@gmail.com";

                using (var client = new SmtpClient(smtpServer, smtpPort))
                {
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(fromEmail, password);

                    using (var mail = new MailMessage())
                    {
                        mail.From = new MailAddress(fromEmail, "Sistema");
                        mail.To.Add(toEmail);
                        mail.Subject = "⚠ Erro no Sistema";
                        mail.Body = $"Uma falha ocorreu:\n\n{mensagemErro}";
                        mail.SubjectEncoding = Encoding.UTF8;
                        mail.BodyEncoding = Encoding.UTF8;
                        mail.IsBodyHtml = false;

                        client.Send(mail);
                    }
                }
            }
            catch
            {
               
            }
        }
    }
}
