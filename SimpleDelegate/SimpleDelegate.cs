using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class SimpleDelegate
    {
        public delegate void Del(string message);
        static void Main(string[] args)
        {
            //Instantiate the delegate
            Del handler = DelegateMethod;

            Del handler2 = DelegateMethod2;

            //Call the delegate
            handler("Hello World");

            handler2.Invoke("This is through invoke: Hello World");

            Console.ReadKey();
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void DelegateMethod2(string message)
        {
            Console.WriteLine(message);
        }


    }
}
