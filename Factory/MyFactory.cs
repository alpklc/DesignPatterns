using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class MyFactory
    {
        public IProduct GetProuduct(ProductType type)
        {
            if (type == ProductType.A)
                return new ProductA();
            else if (type == ProductType.B)
                return new ProductB();
            else
                throw new ArgumentException();
        }
    }
}
