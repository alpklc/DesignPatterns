using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Version2
{
    public class WeatherSubject : IMySubject
    {
        private readonly List<IMyObserver> _observers;
        private WeatherTypeEnum _currentWeather;
        
        public WeatherSubject()
        {
            _observers= new List<IMyObserver>();
            _currentWeather = GenerateNewWeather();
        }
        public void AddObserver(IMyObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void RemoveObserver(IMyObserver observer)
        {
            _observers.Remove(observer);
        }
        public WeatherTypeEnum GetWeatherType()
        {
            return _currentWeather;
        }
        public int GetNumberOfObservers()
        {
            return _observers.Count;
        }
        public void TimePasses()
        {
            Console.WriteLine("Time has been passing...");
            _currentWeather = GenerateNewWeather();
            NotifyObservers();
        }
        private WeatherTypeEnum GenerateNewWeather()
        {
            Random random = new Random();
            int index = random.Next() % Enum.GetNames(typeof(WeatherTypeEnum)).Length;
            return (WeatherTypeEnum)index;
        }
    }
}
