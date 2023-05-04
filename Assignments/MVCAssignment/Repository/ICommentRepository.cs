using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Data;
using MVCAssignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
{
    public interface ICommentRepository
    {
        Task<ActionResult<CommentModel>> AddComment(EventViewModel bookEvent);
        Task<List<CommentModel>> GetComments(int id);
    }
}