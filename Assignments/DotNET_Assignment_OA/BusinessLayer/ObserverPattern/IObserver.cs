using DomainLayer.Models;

namespace BusinessLayer.ObserverPattern
{
    public interface IObserver
    {
        void Update(EventViewModel eventView);
    }
}