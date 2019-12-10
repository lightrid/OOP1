using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Mail;


namespace OOP2
{
    class Email
    {
        private String from;
        private String password;
        private String smtpServer;
        private String mailto;
        private String caption;
        private String message;

        public Email()
        {
            this.from = "mykhailo.kviatkovskyi.kn.2017@lpnu.ua";
            this.password = "12.11.1997";
            this.smtpServer = "smtp.gmail.com";
        }

        public void ItemsAdded(int id,String name,int amount, String client)
        {
            mailto = client;
            caption = "Поповнення товару";
           message = "На слад додано товар №" + id.ToString() + " " + name + " в кількості " + amount.ToString();
            SendMail();
        }
        public void ItemsDeleted(int id, String name, int amount, String client)
        {
            mailto = client;
            caption = "Вилучення товару";
            message = "Припинені поставки товару №" + id.ToString() + " " + name;
            SendMail();
        }


        public void SendMail()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(mailto));
            mail.Subject = caption;
            mail.Body = message;
            SmtpClient smtp = new SmtpClient(); 
            smtp.Host = smtpServer;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(from, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(mail);
            mail.Dispose();

        }

    }
}
