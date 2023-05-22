

using DomainLayer.Models;
using System;

namespace BusinessLayer.ObserverPattern
{
    public class Subject : ISubject
    {
        private IObserver _observer;

        public Subject(IObserver observer)
        {
            _observer = observer;
        }
        public void NotifyObserver(EventViewModel eventView)
        {
            _observer.Update(eventView);
        }
    }
}
