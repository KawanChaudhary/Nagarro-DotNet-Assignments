using BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Service.Implementation;
using ServiceLayer.Service.Interface;
using System.Threading.Tasks;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade.ConcreteEvent
{
    public class AddEventManager : IAddEventManager
    {
        private readonly IBookEventService _bookEventRepository;
        private readonly IInvitationService _invitationRepository;
        private readonly ICommentService _commentRepository;

        public AddEventManager(IBookEventService bookEventRepository, IInvitationService invitationRepository,
            ICommentService commentRepository)
        {
            _bookEventRepository = bookEventRepository;
            _invitationRepository = invitationRepository;
            _commentRepository = commentRepository;
        }

        public AddEventManager()
        {
        }

        [Authorize]
        public async Task<int> AddNewBookEvent(EventViewModel bookEvent)
        {
            var eventId = await _bookEventRepository.AddNewBookEvent(bookEvent);
            bookEvent.EventDetails.Id = eventId;
            await AddInvitation(bookEvent);
            return eventId;
        }
        [Authorize]
        public async Task<ActionResult<CommentModel>> AddComment(EventViewModel bookEvent)
        {
            return await _commentRepository.AddComment(bookEvent);
        }

        [Authorize]
        public async Task AddInvitation(EventViewModel bookEvent)
        {
            await _invitationRepository.AddInvitation(bookEvent);
        }

    }
}
