using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent
{
    public interface IEditEventManager
    {
        Task<ActionResult<EventViewModel>> UpdateEvent(EventViewModel bookEvent);
    }
}