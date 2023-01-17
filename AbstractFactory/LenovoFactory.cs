using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LenovoFactory : IConsumerElectronicsFactory
    {
        public ILaptop ManufactureLaptop()
        {
            return new LenovoLaptop();
        }

        public IMonitor ManufactureMonitor()
        {
            return new LenovoMonitor();
        }
    }
}
