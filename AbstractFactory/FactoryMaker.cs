using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FactoryMaker
    {
        public static IConsumerElectronicsFactory MakeFactory(FactoryBrand brand)
        {
            if (brand == FactoryBrand.Dell)
                return new DellFactory();
            else if (brand == FactoryBrand.Lenovo)
                return new LenovoFactory();
            else if (brand == FactoryBrand.Hp)
                return new HpFactory();
            else
                throw new ArgumentException();
        }
    }
}
