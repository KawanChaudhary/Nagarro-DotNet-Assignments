using DomainLayer.Models;

namespace BusinessLayer.ObserverPattern
{
    public interface ISubject
    {
        void NotifyObserver(EventViewModel eventView);
    }
}