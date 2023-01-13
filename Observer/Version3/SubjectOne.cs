using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Version3
{
    public class SubjectOne : IMySubject
    {
        private readonly List<IMyObserver> _observers;
        private StateOne _state;
        public SubjectOne()
        {
            _observers = new List<IMyObserver>();
            _state = new StateOne
            {
                StateValue1 = 1,
                StateValue2 = "Test"
            };
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
        public StateOne GetStateOne()
        {
            return _state;
        }
        public void SetStateOne(StateOne state)
        {
            _state = state;
            NotifyObservers();
        }
        public int GetNumberOfObservers()
        {
            return _observers.Count;
        }
    }
}
