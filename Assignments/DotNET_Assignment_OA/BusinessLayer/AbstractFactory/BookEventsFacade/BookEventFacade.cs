using BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade
{
    public class BookEventFacade : IBookEventFacade
    {
        private readonly IGetEventManager getEventManager;
        private readonly IAddEventManager addEventManager;
        private readonly IEditEventManager editEventManager;

        public BookEventFacade(IGetEventManager getEventManager, IAddEventManager addEventManager, 
            IEditEventManager editEventManager)
        {
            this.getEventManager = getEventManager;
            this.addEventManager = addEventManager;
            this.editEventManager = editEventManager;
        }

        public IGetEventManager GetDetails()
        {
            return getEventManager;
        }

        public IAddEventManager AddDetails()
        {
            return addEventManager;
        }

        public IEditEventManager EditDetails()
        {
            return editEventManager;
        }

    }
}
