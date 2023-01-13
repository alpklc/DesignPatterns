using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Version2
{
    public interface IMySubject
    {
        void AddObserver(IMyObserver observer);
        void RemoveObserver(IMyObserver observer);
        void NotifyObservers();
    }
}
