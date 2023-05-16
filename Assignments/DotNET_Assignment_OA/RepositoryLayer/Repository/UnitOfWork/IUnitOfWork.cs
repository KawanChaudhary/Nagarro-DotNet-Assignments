using RepositoryLayer.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IBookEventRepository BookEventRepository { get; }
        ICommentRepository CommentRepository { get; }
        IInvitationRepository InvitationRepository { get; }
        Task CompleteAsync();
    }
}
