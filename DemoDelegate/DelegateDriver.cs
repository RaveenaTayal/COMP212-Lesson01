using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    class DelegateDriver
    {
        delegate void SumDelegate(int x, int y);
        static void Main(string[] args)
        {
            SumDelegate objDelegate = sum;

            objDelegate(10, 20);
            Console.ReadLine();
        }

        public static void sum(int x, int y)
        {
            Console.WriteLine((x+y).ToString());
        }
    }
}
