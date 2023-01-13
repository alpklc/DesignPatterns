using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Weather
    {
        private readonly List<IWeatherObserver> _observers;
        private WeatherTypeEnum _currentWeather;   // State
        public Weather()
        {
            _observers = new List<IWeatherObserver>();
            _currentWeather = WeatherTypeEnum.SUNNY;
        }
        public void AddObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IWeatherObserver observer) 
        {
            _observers.Remove(observer);   
        }
        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void TimePasses()
        {
            Random random = new Random();
            int index = random.Next() % Enum.GetNames(typeof(WeatherTypeEnum)).Length;
            _currentWeather = (WeatherTypeEnum)index;
            NotifyObservers();
        }

        public WeatherTypeEnum GetCurrentWeather()
        {
            return _currentWeather;
        }
        public int GetNumberOfObservers()
        {
            return _observers.Count;
        }
    }
}
