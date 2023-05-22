using DomainLayer.Data;
using DomainLayer.Models;
using DomainLayer.OtherFiles;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Repository.UnitOfWork;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Implementation
{
    public class BookEventService : IBookEventService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;

        public BookEventService(IUnitOfWork unitOfWork, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
        }


        private bool PersonalEvents(BookEventEntity bookEvent)
        {
            if (_userService.IsAuthenticated())
            {
                if (_userService.IsAdmin() is true) return true;

                var userID = _userService.GetUserId();

                if (!string.IsNullOrEmpty(bookEvent.CreatedBy) && userID == bookEvent.CreatedBy)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<int> AddNewBookEvent(EventViewModel model)
        {
            var newEvent = new BookEventEntity()
            {
                Title = model.EventDetails.Title,
                Date = model.EventDetails.Date,
                StartTime = model.EventDetails.StartTime,
                Location = model.EventDetails.Location,
                Description = model.EventDetails.Description,
                Duration = model.EventDetails.Duration,
                Type = model.EventDetails.Type,
                InviteByEmail = model.EventDetails.InviteByEmail,
                CreatedBy = _userService.GetUserId(),
                OtherDetails = model.EventDetails.OtherDetails,
                Count = model.EventDetails.Count,
                CommentAdded = model.EventDetails.CommentAdded,

                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };

            await _unitOfWork.BookEventRepository.Add(newEvent);
            await _unitOfWork.CompleteAsync();
            
            return newEvent.Id;
        }

        public async Task<ActionResult<EventViewModel>> UpdateEvent(EventViewModel bookEvent)
        {
            var eventPost =  await _unitOfWork.BookEventRepository.GetById(bookEvent.EventDetails.Id);

            eventPost.Title = bookEvent.EditEventDetails.Title;
            eventPost.Date = bookEvent.EditEventDetails.Date;
            eventPost.StartTime = bookEvent.EditEventDetails.StartTime;
            eventPost.Location = bookEvent.EditEventDetails.Location;
            eventPost.Duration = bookEvent.EditEventDetails.Duration;
            eventPost.Type = bookEvent.EditEventDetails.Type;
            eventPost.Description = bookEvent.EditEventDetails.Description;
            eventPost.InviteByEmail = bookEvent.EditEventDetails.InviteByEmail;
            eventPost.OtherDetails = bookEvent.EditEventDetails.OtherDetails;
            eventPost.UpdatedOn = DateTime.Now;

            var res = await _unitOfWork.BookEventRepository.Update(eventPost);
            await _unitOfWork.CompleteAsync();
            return new EventViewModel
            {
                EventDetails = bookEvent.EventDetails
            };
        }

        public async Task<List<BookEventModel>> GetMyBookEvent()
        {
            var myBookEvents = new List<BookEventModel>();

            var allBookEvents = await _unitOfWork.BookEventRepository.All();

            if (allBookEvents?.Any() == true)
            {
                var userID = _userService.GetUserId();
                foreach (var bookEvent in allBookEvents)
                {
                    if (!string.IsNullOrEmpty(bookEvent.CreatedBy) && userID == bookEvent.CreatedBy)
                    {

                        myBookEvents.Add(new BookEventModel()
                        {
                            Id = bookEvent.Id,
                            Title = bookEvent.Title,
                            Date = bookEvent.Date,
                            StartTime = bookEvent.StartTime,
                            Location = bookEvent.Location,
                            Description = bookEvent.Description,
                            Duration = bookEvent.Duration,
                            Type = bookEvent.Type,
                            InviteByEmail = bookEvent.InviteByEmail,
                            CreatedBy = bookEvent.CreatedBy,
                            OtherDetails = bookEvent.OtherDetails,
                            Count = bookEvent.Count,
                            CommentAdded = bookEvent.CommentAdded,
                        });
                    }
                }
            }
            return myBookEvents;
        }

        public async Task<List<BookEventModel>> GetAllBookEvent()
        {
            var bookEvents = new List<BookEventModel>();
            var allBookEvents = await _unitOfWork.BookEventRepository.All();

            if (allBookEvents?.Any() == true)
            {
                foreach (var bookEvent in allBookEvents)
                {
                    bookEvents.Add(new BookEventModel()
                    {
                        Id = bookEvent.Id,
                        Title = bookEvent.Title,
                        Date = bookEvent.Date,
                        StartTime = bookEvent.StartTime,
                        Location = bookEvent.Location,
                        Description = bookEvent.Description,
                        Duration = bookEvent.Duration,
                        Type = bookEvent.Type,
                        InviteByEmail = bookEvent.InviteByEmail,
                        CreatedBy = bookEvent.CreatedBy,
                        OtherDetails = bookEvent.OtherDetails,
                        Count = bookEvent.Count,
                        CommentAdded = bookEvent.CommentAdded,
                    });
                }
            }
            return bookEvents;
        }

        public async Task<BookEventModel> GetBookEventById(int id)
        {
            var bookEventById = await _unitOfWork.BookEventRepository.GetById(id);
            if (bookEventById is { })
            {
                var eventDetails = new BookEventModel()
                {
                    Id = bookEventById.Id,
                    Title = bookEventById.Title,
                    Date = bookEventById.Date,
                    StartTime = bookEventById.StartTime,
                    Location = bookEventById.Location,
                    Description = bookEventById.Description,
                    Duration = bookEventById.Duration,
                    Type = bookEventById.Type,
                    InviteByEmail = bookEventById.InviteByEmail,
                    CreatedBy = bookEventById.CreatedBy,
                    OtherDetails = bookEventById.OtherDetails,
                    Count = bookEventById.Count,
                    CommentAdded = bookEventById.CommentAdded,
                };
                return eventDetails;
            }
            return null;
        }

        public async Task<List<BookEventModel>> GetUpcomingBookEvent()
        {
            var bookEvents = new List<BookEventModel>();
            var allBookEvents = await _unitOfWork.BookEventRepository.All();
            if (allBookEvents?.Any() == true)
            {
                DateTime todayDate = DateTime.UtcNow;


                foreach (var bookEvent in allBookEvents)
                {
                    DateTime dt1 = bookEvent.Date;
                    DateTime dt2 = bookEvent.StartTime;
                    DateTime eventDate = new DateTime(dt1.Year, dt1.Month, dt1.Day, dt2.Hour, dt2.Minute, dt2.Second);

                    bool isPossibleToShow = bookEvent.Type == EventType.Public || PersonalEvents(bookEvent);

                    if (DateTime.Compare(eventDate, todayDate) >= 0 && isPossibleToShow)
                    {

                        bookEvents.Add(new BookEventModel()
                        {
                            Id = bookEvent.Id,
                            Title = bookEvent.Title,
                            Date = bookEvent.Date,
                            StartTime = bookEvent.StartTime,
                            Location = bookEvent.Location,
                            Description = bookEvent.Description,
                            Duration = bookEvent.Duration,
                            Type = bookEvent.Type,
                            InviteByEmail = bookEvent.InviteByEmail,
                            CreatedBy = bookEvent.CreatedBy,
                            OtherDetails = bookEvent.OtherDetails,
                            Count = bookEvent.Count,
                            CommentAdded = bookEvent.CommentAdded,
                        });
                    }
                }
            }
            return bookEvents;
        }

        public async Task<List<BookEventModel>> GetPastBookEvent()
        {
            var bookEvents = new List<BookEventModel>();
            var allBookEvents = await _unitOfWork.BookEventRepository.All();
            if (allBookEvents?.Any() == true)
            {
                DateTime todayDate = DateTime.UtcNow;


                foreach (var bookEvent in allBookEvents)
                {
                    DateTime dt1 = bookEvent.Date;
                    DateTime dt2 = bookEvent.StartTime;
                    DateTime eventDate = new DateTime(dt1.Year, dt1.Month, dt1.Day, dt2.Hour, dt2.Minute, dt2.Second);

                    bool isPossibleToShow = bookEvent.Type == EventType.Public || PersonalEvents(bookEvent);

                    if (DateTime.Compare(eventDate, todayDate) < 0 && isPossibleToShow)
                    {

                        bookEvents.Add(new BookEventModel()
                        {
                            Id = bookEvent.Id,
                            Title = bookEvent.Title,
                            Date = bookEvent.Date,
                            StartTime = bookEvent.StartTime,
                            Location = bookEvent.Location,
                            Description = bookEvent.Description,
                            Duration = bookEvent.Duration,
                            Type = bookEvent.Type,
                            InviteByEmail = bookEvent.InviteByEmail,
                            CreatedBy = bookEvent.CreatedBy,
                            OtherDetails = bookEvent.OtherDetails,
                            Count = bookEvent.Count,
                            CommentAdded = bookEvent.CommentAdded,
                        });
                    }
                }
            }
            return bookEvents;
        }
    }
}