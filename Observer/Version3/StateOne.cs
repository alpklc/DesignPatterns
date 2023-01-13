using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Version3
{
    public class StateOne
    {
        public int StateValue1 { get; set; }
        public string? StateValue2 { get; set; }

        public override string ToString()
        {
            return $"{StateValue1}, {StateValue2}";
        }
    }
}
