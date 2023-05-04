using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
{
    public interface IBookEventRepository
    {
        Task<int> AddNewBookEvent(EventViewModel model);
        Task<List<BookEventModel>> GetAllBookEvent();
        Task<EventViewModel> GetBookEventById(int id);
        Task<List<BookEventModel>> GetMyBookEvent();
        Task<List<BookEventModel>> GetPastBookEvent();
        Task<List<BookEventModel>> GetUpcomingBookEvent();
        Task<ActionResult<EventViewModel>> UpdateEvent(EventViewModel bookEvent);
    }
}