using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HpFactory : IConsumerElectronicsFactory
    {
        public ILaptop ManufactureLaptop()
        {
            return new HpLaptop();
        }

        public IMonitor ManufactureMonitor()
        {
            return new HpMonitor();
        }
    }
}
