using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LenovoFactory : IConsumerElectonicsFactory
    {
        public IProduct ManufactureProduct(ProductType type)
        {
            IProduct product = new LenovoProduct(type);
            return product;
        }
    }
}
