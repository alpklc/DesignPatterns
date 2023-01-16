using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DellFactory : IConsumerElectonicsFactory
    {
        public IProduct ManufactureProduct(ProductType type)
        {
            IProduct product = new DellProduct(type);
            return product;
        }
    }
}
