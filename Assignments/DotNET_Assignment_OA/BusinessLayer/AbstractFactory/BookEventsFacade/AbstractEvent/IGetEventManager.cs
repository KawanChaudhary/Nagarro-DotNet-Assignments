using DomainLayer.Data;
using DomainLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent
{
    public interface IGetEventManager
    {
        Task<List<BookEventModel>> GetAllBookEvents();
        Task<BookEventModel> GetBookEventById(int id);
        Task<List<CommentModel>> GetComments(int id);
        Task<List<BookEventModel>> GetMyBookEvent();
        Task<List<InvitationEntity>> GetMyInvitations();
        Task<List<BookEventModel>> GetPastBookEvent();
        Task<List<BookEventModel>> GetUpcomingBookEvent();
    }
}