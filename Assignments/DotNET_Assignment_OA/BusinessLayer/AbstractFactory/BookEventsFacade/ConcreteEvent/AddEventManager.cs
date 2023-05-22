using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent;
using BusinessLayer.ObserverPattern;
using BusinessLayer.PublisherSubscriberPattern;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Log;
using ServiceLayer.Logger;
using ServiceLayer.Service.Interface;
using System.Threading.Tasks;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade.ConcreteEvent
{
    public class AddEventManager : IAddEventManager
    {
        private readonly IBookEventService _bookEventService;
        private readonly IInvitationService _invitationService;
        private readonly ICommentService _commentService;
        private readonly ISubject subject;
        private readonly IPublisher publisher;
        private readonly IUserService userService;
        private readonly INotyfService notyfService;

        private ILogger _iLog;

        public AddEventManager(IBookEventService bookEventService, IInvitationService invitationService,
            ICommentService commentService, ISubject subject, IPublisher publisher, IUserService userService, 
            INotyfService notyfService)
        {
            _bookEventService = bookEventService;
            _invitationService = invitationService;
            _commentService = commentService;
            this.subject = subject;
            this.publisher = publisher;
            this.userService = userService;
            this.notyfService = notyfService;

            _iLog = Logger.GetInstance;
        }


        [Authorize]
        public async Task<int> AddNewBookEvent(EventViewModel bookEvent)
        {
            var eventId = await _bookEventService.AddNewBookEvent(bookEvent);
            bookEvent.EventDetails.Id = eventId;
            if(!string.IsNullOrEmpty(bookEvent.EventDetails.InviteByEmail)) 
                await AddInvitation(bookEvent);

            _iLog.LogDetails($"New book Event: \nID: {bookEvent.EventDetails.Id}" +
                $"\nTitle: {bookEvent.EventDetails.Title}" );

            return eventId;
        }
        [Authorize]
        public async Task<ActionResult<CommentModel>> AddComment(EventViewModel bookEvent)
        {


            var newComment =  await _commentService.AddComment(bookEvent);
            var book = await _bookEventService.GetBookEventById(bookEvent.EventDetails.Id);
            bookEvent.EventDetails = book;
            bookEvent.Comment = newComment.Value;

            _iLog.LogDetails($"Adding a new comment on {bookEvent.EventDetails.Title} book event");

            // Observer PAttern
            // subject.NotifyObserver(bookEvent);

            // Pub-Sub Pattern

            publisher.OnChange += (sender, eventView) =>
            {
                if (userService.GetUserId() == eventView.bookEvent.EventDetails.CreatedBy)
                {
                    string msg = eventView.bookEvent.Comment.FirstName + " commented on your post: " + eventView.bookEvent.EventDetails.Title;
                    notyfService.Custom(msg, 10, "whitesmoke", "fa fa-comments");
                }
            };

            publisher.Raise(bookEvent);

            return newComment;
        }

        [Authorize]
        public async Task AddInvitation(EventViewModel bookEvent)
        {
            await _invitationService.AddInvitation(bookEvent);
        }

    }
}
