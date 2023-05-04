using MVCAssignment.Data;
using MVCAssignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
{
    public interface IInvitationRepository
    {
        Task AddInvitation(EventViewModel bookEvent, string userId);
        Task<List<InvitationEntity>> GetMyInvitations();
    }
}