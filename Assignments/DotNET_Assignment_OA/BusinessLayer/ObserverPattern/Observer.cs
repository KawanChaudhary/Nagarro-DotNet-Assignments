using AspNetCoreHero.ToastNotification.Abstractions;
using DomainLayer.Models;
using ServiceLayer.Service.Interface;

namespace BusinessLayer.ObserverPattern
{
    public class Observer : IObserver
    {
        private readonly IUserService userService;
        private readonly INotyfService notyfService;
        public Observer(IUserService userService, INotyfService notyfService)
        {
            this.userService = userService;
            this.notyfService = notyfService;
        }

        public void Update(EventViewModel eventView)
        {
            if (userService.GetUserId() == eventView.EventDetails.CreatedBy)
            {
                string msg = eventView.Comment.FirstName + " commented on your post: " + eventView.EventDetails.Title;
                notyfService.Custom(msg, 10, "whitesmoke", "fa fa-comments");
            }
        }
    }
}
