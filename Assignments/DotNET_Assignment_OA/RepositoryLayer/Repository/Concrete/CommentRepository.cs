using DomainLayer.Data;
using RepositoryLayer.Repository.Interface;

namespace RepositoryLayer.Repository.Concrete
{
    public class CommentRepository : GenericRepository<CommentEntity>, ICommentRepository
    {
        public CommentRepository(BookEventContext context) : base(context) { }

    }
}
