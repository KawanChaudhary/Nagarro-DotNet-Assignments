using BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Service.Implementation;
using ServiceLayer.Service.Interface;
using System.Threading.Tasks;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade.ConcreteEvent
{
    public class EditEventManager :  IEditEventManager
    {
        private readonly IBookEventService _bookEventRepository;
        private readonly IInvitationService _invitationRepository;

        public EditEventManager()
        {
        }

        public EditEventManager(IBookEventService bookEventRepository, IInvitationService invitationRepository)
        {
            _bookEventRepository = bookEventRepository;
            _invitationRepository = invitationRepository;
        }

        [Authorize]
        public async Task<ActionResult<EventViewModel>> UpdateEvent(EventViewModel bookEvent)
        {
            var editEvent = await _bookEventRepository.UpdateEvent(bookEvent);
            await _invitationRepository.AddInvitation(bookEvent);
            return editEvent;
        }
    }
}
