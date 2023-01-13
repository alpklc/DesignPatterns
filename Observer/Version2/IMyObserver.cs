using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Version2
{
    public interface IMyObserver
    {
        void Update(IMySubject subject);
    }
}
