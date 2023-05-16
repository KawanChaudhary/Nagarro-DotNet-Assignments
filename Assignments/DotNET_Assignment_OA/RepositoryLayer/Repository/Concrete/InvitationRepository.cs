using DomainLayer.Data;
using RepositoryLayer.Repository.Interface;

namespace RepositoryLayer.Repository.Concrete
{
    public class InvitationRepository : GenericRepository<InvitationEntity>, IInvitationRepository
    {
        public InvitationRepository(BookEventContext context) : base(context) { }

    }
}
