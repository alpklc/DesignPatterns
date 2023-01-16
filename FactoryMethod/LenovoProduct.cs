using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LenovoProduct : IProduct
    {
        private readonly ProductType _type;
        public LenovoProduct(ProductType type)
        {
            _type = type;
        }
        public ProductType GetProductType()
        {
            return _type;
        }
        public override string ToString()
        {
            return $"This is a Lenovo {_type}";
        }
    }
}
