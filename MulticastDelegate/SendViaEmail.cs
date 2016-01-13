using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class SendViaEmail
    {
        private String emailAddr;

        //CONSTRUCTORS
        public SendViaEmail()
        {

        }

        public SendViaEmail(string emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void setEmailAddr(string emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public string getEmailAddr()
        {
            return this.emailAddr;
        }

        public void sendEmail(string msg)
        {
            Console.WriteLine("The message \" {0} \"was sent to {1}",msg,this.emailAddr);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
        }
    }
}
