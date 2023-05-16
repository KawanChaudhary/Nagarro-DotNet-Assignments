using DomainLayer.Data;
using DomainLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interface
{
    public interface IInvitationService
    {
        Task AddInvitation(EventViewModel bookEvent);
        Task<List<InvitationEntity>> GetMyInvitations();
    }
}