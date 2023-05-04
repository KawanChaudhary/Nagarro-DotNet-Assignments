using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MVCAssignment.Data;
using MVCAssignment.Models;
using MVCAssignment.OtherFiles;
using MVCAssignment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
{
    public class BookEventRepository : IBookEventRepository
    {
        private readonly BookEventContext _context = null;
        private readonly IUserService _userService;
        private readonly IInvitationRepository _invitationRepository;

        public BookEventRepository(BookEventContext context, IUserService userService, IInvitationRepository invitationRepository)
        {
            _context = context;
            _userService = userService;
            _invitationRepository = invitationRepository;
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

            await _context.BookEventEntities.AddAsync(newEvent);
            await _context.SaveChangesAsync();
            model.EventDetails.Id = newEvent.Id;
            await _invitationRepository.AddInvitation(model, _userService.GetEmail());
            return newEvent.Id;
        }

        public async Task<ActionResult<EventViewModel>> UpdateEvent(EventViewModel bookEvent)
        {
            var eventPost = await _context.BookEventEntities.FindAsync(bookEvent.EventDetails.Id);

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

            var res = _context.BookEventEntities.Update(eventPost);
            await _context.SaveChangesAsync();
            return new EventViewModel
            {
                EventDetails = bookEvent.EventDetails
            };
        }

        public async Task<List<BookEventModel>> GetMyBookEvent()
        {
            var myBookEvents = new List<BookEventModel>();
            var allBookEvents = await _context.BookEventEntities.ToListAsync();



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
            var allBookEvents = await _context.BookEventEntities.ToListAsync();
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

        public async Task<EventViewModel> GetBookEventById(int id)
        {
            var bookEventById = await _context.BookEventEntities.FindAsync(id);
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
                return new EventViewModel
                {
                    EventDetails = eventDetails
                };
            }
            return null;
        }

        public async Task<List<BookEventModel>> GetUpcomingBookEvent()
        {
            var bookEvents = new List<BookEventModel>();
            var allBookEvents = await _context.BookEventEntities.ToListAsync();
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
            var allBookEvents = await _context.BookEventEntities.ToListAsync();
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


        /*private List<BookEventModel> DataSource()
        {
            DateTime V = Convert.ToDateTime("2023/05/12");
            DateTime X = Convert.ToDateTime("08:15");
            EventType T = EventType.Public;
            string desc = "A computer language is a formal language used to communicate with a computer. " +
                "Types of computer languages include: Construction language – all forms of communication " +
                "by which a human can specify an executable problem solution to a computer.";

            return new List<BookEventModel>()
            {
                new BookEventModel(){Id=1, Title="MVC", Date=V, Location="Delhi", StartTime=X, Type=T, Description=desc, Duration=3},
                new BookEventModel(){Id=2, Title="React", Date=V, Location="Delhi", StartTime=X, Type=T, Description=desc},
                new BookEventModel(){Id=3, Title="Angular", Date=V, Location="Delhi", StartTime=X, Type=T, Description=desc, Duration=6},
                new BookEventModel(){Id=4, Title="C#", Date=V, Location="Delhi", StartTime=X, Type=T, Description=desc},
                new BookEventModel(){Id=5, Title="C++", Date=V, Location="Delhi", StartTime=X, Type=T, Description=desc, Duration=12,InviteByEmail="kawan@gamil.com"},
            };
        }*/

    }
}