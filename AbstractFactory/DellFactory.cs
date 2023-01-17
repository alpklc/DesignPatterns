using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class DellFactory : IConsumerElectronicsFactory
    {
        public ILaptop ManufactureLaptop()
        {
            return new DellLaptop();
        }

        public IMonitor ManufactureMonitor()
        {
            return new DellMonitor();
        }
    }
}
