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
            SenderMail = "gustavoFazen@gmail.com";
            Password = "zxmnk9ds#";
            Host = "smtp.gmail.com";
            Port = 587 ;
            Ssl = true ;
   
            InitializeSmtpClient();
        }
    }
}
