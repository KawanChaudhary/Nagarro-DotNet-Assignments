using BusinessLayer.AbstarctFactory.BookEventsFacade;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Service.Validators;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookEventFacade bookEventFacade;

        public BookController()
        {

        }
        [ActivatorUtilitiesConstructor]
        public BookController(IBookEventFacade bookEventFacade)
        {
            this.bookEventFacade = bookEventFacade;
        }


        public IActionResult Book()
        {
            return View();
        }

        public ViewResult GetAllBookEvent()
        {
            
            /*var getDetails = bookEventFacade.GetDetails();
            var data = await getDetails.GetAllBookEvents();*/

            return View();
        }

        [Authorize]
        public async Task<ViewResult> GetMyBookEvent()
        {
            var getDetails = bookEventFacade.GetDetails();
            var data = await getDetails.GetMyBookEvent();
            return View(data);
        }

        [Route("event-details/{id}", Name = "eventDetailsRoute")]
        public async Task<IActionResult> GetBookEvent(int id)
        {
            var getDetails = bookEventFacade.GetDetails();            ;

            var eventDetails = await getDetails.GetBookEventById(id);

            var allComments = await getDetails.GetComments(id);

            var data = new EventViewModel()
            {
                EventDetails = eventDetails,
                AllComments = allComments
            };
            return View(data);
        }

        [Authorize]
        public ViewResult AddNewEvent(bool isSuccess = false, int eventId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.EventId = eventId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewEvent(EventViewModel bookEvent)
        {
            var validator = new BookEventValidator();
            var res = validator.Validate(bookEvent.EventDetails);

            if (!res.IsValid)
            {
                return BadRequest(res.Errors);
            }

            var addDetails = bookEventFacade.AddDetails();

            int id = await addDetails.AddNewBookEvent(bookEvent);

            if (id > 0)
            {
                ViewBag.IsSuccess = true;
                return RedirectToAction(nameof(AddNewEvent), new { isSuccess = true, eventId = id });
            }
            return View();
        }


        // Comment
        public async Task<IActionResult> AddComment(EventViewModel bookEvent)
        {
            var validator = new CommentValidator();
            var res = validator.Validate(bookEvent.Comment);

            if (!res.IsValid)
            {
                return BadRequest(res.Errors);
            }

            var addDetails = bookEventFacade.AddDetails();

            var result = await addDetails.AddComment(bookEvent);

            if (result.Result is null)
                return RedirectToAction("GetBookEvent", new { bookEvent.EventDetails.Id });

            return result.Result;
        }

        // Edit
        public async Task<IActionResult> EditEvent(int id)
        {
            var getDetails = bookEventFacade.GetDetails();

            var res = await getDetails.GetBookEventById(id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEvent(EventViewModel bookEvent)
        {
            var validator = new BookEventValidator();
            var res = validator.Validate(bookEvent.EventDetails);

            if (!res.IsValid)
            {
                return BadRequest(res.Errors);
            }

            var editDetails = bookEventFacade.EditDetails();

            var result = await editDetails.UpdateEvent(bookEvent);

            if (result.Result is null)
                return RedirectToAction("GetBookEvent", new { bookEvent.EventDetails.Id });

            return result.Result;
        }


    }
}
