using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent
{
    public interface IAddEventManager
    {
        Task<ActionResult<CommentModel>> AddComment(EventViewModel bookEvent);
        Task AddInvitation(EventViewModel bookEvent);
        Task<int> AddNewBookEvent(EventViewModel bookEvent);
    }
}