using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Repository;
using MVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MVCAssignment.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookEventRepository _bookEventRepository = null;
        private readonly ICommentRepository _commentRepository;

        public BookController(IBookEventRepository bookEventRepository, ICommentRepository commentRepository)
        {
            _bookEventRepository = bookEventRepository;
            _commentRepository = commentRepository;
        }

        public async Task<ViewResult> GetAllBookEvent()
        {
            var data = await _bookEventRepository.GetAllBookEvent();
            return View(data);
        }

        public async Task<ViewResult> GetMyBookEvent()
        {
            var data = await _bookEventRepository.GetMyBookEvent();
            return View(data);
        }

        [Route("event-details/{id}", Name="eventDetailsRoute")]
        public async Task<IActionResult> GetBookEvent(int id)
        {
            var data = await _bookEventRepository.GetBookEventById(id);
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
            int id = await _bookEventRepository.AddNewBookEvent(bookEvent);
            if(id > 0)
            {
                return RedirectToAction(nameof(AddNewEvent), new { isSuccess = true, eventId = id });
            }
            return View();
        }        

        public IActionResult Index()
        {
            return View();
        }

        // Comment
        public async Task<IActionResult> AddComment(EventViewModel bookEvent)
        {
            var res = await _commentRepository.AddComment(bookEvent);
            if (res.Result is null)
                return RedirectToAction("GetBookEvent", new { bookEvent.EventDetails.Id });

            return res.Result;
        }

        // Edit
        public async Task<IActionResult> EditEvent(int id)
        {
            var res = await _bookEventRepository.GetBookEventById(id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEvent(EventViewModel bookEvent)
        {
            var res = await _bookEventRepository.UpdateEvent(bookEvent);

            if (res.Result is null)
                return RedirectToAction("GetBookEvent", new { bookEvent.EventDetails.Id });

            return res.Result;
        }


    }
}
