using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Version2
{
    public class TeacherObserver : IMyObserver
    {
        public void Update(IMySubject subject)
        {
            Console.WriteLine(((WeatherSubject)subject).GetWeatherType());
        }
    }
}
