using DomainLayer.Models;
using System;

namespace BusinessLayer.PublisherSubscriberPattern
{
    public interface IPublisher
    {
        event EventHandler<CommentNotifyArgs> OnChange;

        void Raise(EventViewModel bookEvent);
    }
}