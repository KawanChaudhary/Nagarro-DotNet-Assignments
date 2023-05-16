using BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent;
using DomainLayer.Data;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using ServiceLayer.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade.ConcreteEvent
{
    public class GetEventManager : IGetEventManager
    {
        private readonly IBookEventService _bookEventService;
        private readonly IInvitationService _invitationService;
        private readonly ICommentService _commentService;

        public GetEventManager(IBookEventService bookEventService, IInvitationService invitationService,
            ICommentService commentService)
        {
            _bookEventService = bookEventService;
            _invitationService = invitationService;
            _commentService = commentService;
        }

        public async Task<List<BookEventModel>> GetAllBookEvents()
        {
            return await _bookEventService.GetAllBookEvent();
        }

        [Authorize]
        public async Task<List<BookEventModel>> GetMyBookEvent()
        {
            return await _bookEventService.GetMyBookEvent();
        }

        public async Task<BookEventModel> GetBookEventById(int id)
        {
            return await _bookEventService.GetBookEventById(id);
        }

        public async Task<List<BookEventModel>> GetUpcomingBookEvent()
        {
            return await _bookEventService.GetUpcomingBookEvent();
        }

        public async Task<List<BookEventModel>> GetPastBookEvent()
        {
            return await _bookEventService.GetPastBookEvent();
        }

        [Authorize]
        public async Task<List<InvitationEntity>> GetMyInvitations()
        {            
            return await _invitationService.GetMyInvitations();           
        }

        public async Task<List<CommentModel>> GetComments(int id)
        {
            return await _commentService.GetComments(id);
        }

    }
}
