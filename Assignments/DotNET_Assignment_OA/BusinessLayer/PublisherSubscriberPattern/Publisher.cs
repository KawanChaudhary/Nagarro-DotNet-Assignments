using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PublisherSubscriberPattern
{
    public delegate void EventHandler(
        object sender,
        EventViewModel e
    );

    public class Publisher : IPublisher
    {
        public event EventHandler<CommentNotifyArgs> OnChange = delegate { };

        public void Raise(EventViewModel bookEvent)
        {
            OnChange(this, new CommentNotifyArgs(bookEvent));
        }

    }
}
