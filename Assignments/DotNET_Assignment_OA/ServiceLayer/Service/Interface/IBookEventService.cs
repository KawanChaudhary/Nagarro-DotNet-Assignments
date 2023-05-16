using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace ServiceLayer.Service.Interface
{
    public interface IBookEventService
    {
        Task<int> AddNewBookEvent(EventViewModel model);
        Task<List<BookEventModel>> GetAllBookEvent();
        Task<BookEventModel> GetBookEventById(int id);
        Task<List<BookEventModel>> GetMyBookEvent();
        Task<List<BookEventModel>> GetPastBookEvent();
        Task<List<BookEventModel>> GetUpcomingBookEvent();
        Task<ActionResult<EventViewModel>> UpdateEvent(EventViewModel bookEvent);
    }
}