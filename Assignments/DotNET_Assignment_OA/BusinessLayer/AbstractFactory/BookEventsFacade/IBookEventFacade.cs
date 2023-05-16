using BusinessLayer.AbstarctFactory.BookEventsFacade.AbstractEvent;

namespace BusinessLayer.AbstarctFactory.BookEventsFacade
{
    public interface IBookEventFacade
    {
        IAddEventManager AddDetails();
        IEditEventManager EditDetails();
        IGetEventManager GetDetails();
    }
}