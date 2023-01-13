using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Teacher : IWeatherObserver
    {
        public void Update(Weather weather)
        {
            Console.WriteLine("Teacher, " + weather.GetCurrentWeather());
        }


    }
}
