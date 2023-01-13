using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class A
    {
        private static A? _instance;
        private A() { }

        public static A GetInstance()
        {
            if (_instance is null)
                _instance = new A();
            return _instance;
        }

        public void DoSomething()
        {
            Console.WriteLine("doing something ...");
        }
    }
}
