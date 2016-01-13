using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Driver
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            SendViaMobile send2Mobile = new SendViaMobile("647 1234567");
            SendViaEmail send2Email = new SendViaEmail("ravhome123@gmail.com");

            send2Mobile.Subscribe(publisher);
            send2Email.Subscribe(publisher);

            publisher.PublishMessage("Hello!!! You have new notifications");
            Console.ReadKey();


        }
    }
}
