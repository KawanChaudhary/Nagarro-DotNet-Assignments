using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace ServiceLayer.Service.Interface
{
    public interface ICommentService
    {
        Task<ActionResult<CommentModel>> AddComment(EventViewModel bookEvent);
        Task<List<CommentModel>> GetComments(int id);
    }
}