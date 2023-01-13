using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Version3
{
    public class ObserverTwo : IMyObserver
    {
        public void Update(IMySubject subject)
        {
            Console.WriteLine(((SubjectOne)subject).GetStateOne());
        }
    }
}
