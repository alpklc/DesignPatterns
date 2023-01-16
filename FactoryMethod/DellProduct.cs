using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DellProduct : IProduct
    {
        private readonly ProductType _type;
        public DellProduct(ProductType type)
        {
            _type = type;
        }
        public ProductType GetProductType()
        {
            return _type;
        }
        public override string ToString()
        {
            return $"This is a Dell {_type}";
        }
    }
}
