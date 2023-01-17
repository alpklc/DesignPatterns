using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HpMonitor : IMonitor
    {
        public override string ToString()
        {
            return "Hp Monitor";
        }
    }
}
