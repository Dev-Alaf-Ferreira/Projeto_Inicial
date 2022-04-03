using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            SenderMail = "desenvolvedoralaf@gmail.com";
            Password = "Zxmnk9ds#";
            Host = "smtp.gmail.com";
            Port = 465 ;
            Ssl = true ;
   
            InitializeSmtpClient();
        }
    }
}
