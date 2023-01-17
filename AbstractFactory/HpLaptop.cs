using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HpLaptop : ILaptop
    {
        public override string ToString()
        {
            return "Hp Laptop";
        }
    }
}
