using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class SendViaMobile
    {
        private String mobilePhone;

        //CONSTRUCTORS
        public SendViaMobile()
        {

        }

        public SendViaMobile(string mobilePhone)
        {
            this.mobilePhone = mobilePhone;
        }

        public void setMobilePhone(string mobilePhone)
        {
            this.mobilePhone = mobilePhone;
        }

        public string getMobilePhone()
        {
            return this.mobilePhone;
        }

        public void sendText(string msg)
        {
            Console.WriteLine("The message \" {0} \"was texted to {1}",msg,this.mobilePhone);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendText;
        }
    }
}
