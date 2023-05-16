using RepositoryLayer.Repository.Concrete;
using RepositoryLayer.Repository.Interface;
using System;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BookEventContext _context;

        public IBookEventRepository BookEventRepository { get; set; }
        public ICommentRepository CommentRepository { get; set; }
        public IInvitationRepository InvitationRepository { get; set; }

        public UnitOfWork(BookEventContext context)
        {
            _context = context;

            BookEventRepository = new BookEventRepository(context);

            CommentRepository = new CommentRepository(context);

            InvitationRepository = new InvitationRepository(context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
