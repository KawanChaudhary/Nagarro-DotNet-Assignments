using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PublisherSubscriberPattern
{
    public class CommentNotifyArgs : EventArgs
    {
        public EventViewModel bookEvent { get; set; }

        public CommentNotifyArgs(EventViewModel bookEvent)
        {
            this.bookEvent = bookEvent;
        }

    }
}
