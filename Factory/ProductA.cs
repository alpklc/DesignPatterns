using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ProductA : IProduct
    {
        public override string ToString()
        {
            return "ProductA";
        }
    }
}
