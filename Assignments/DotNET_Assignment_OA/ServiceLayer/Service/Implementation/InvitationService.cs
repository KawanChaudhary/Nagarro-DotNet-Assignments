using Microsoft.EntityFrameworkCore;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Service.Interface;
using RepositoryLayer;
using DomainLayer.Data;
using RepositoryLayer.Repository.UnitOfWork;

namespace ServiceLayer.Service.Implementation
{
    public class InvitationService : IInvitationService
    {
        private readonly IUnitOfWork _unitOfWork = null;
        private readonly IUserService _userService;

        public InvitationService(IUnitOfWork unitOfWork, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
        }

        public async Task AddInvitation(EventViewModel bookEvent)
        {
            string invitationString = bookEvent.EventDetails.InviteByEmail;
            string userId = _userService.GetEmail();
            string[] values = invitationString.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();

                var newInvitation = new InvitationEntity()
                {
                    Sender = userId,
                    Reciever = values[i],
                    EventId = bookEvent.EventDetails.Id
                };

                await _unitOfWork.InvitationRepository.Add(newInvitation);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<List<InvitationEntity>> GetMyInvitations()
        {
            var myInvitations = new List<InvitationEntity>();
            var allInvitations = await _unitOfWork.InvitationRepository.All();

            if (allInvitations.Any() == true)
            {
                string userId = _userService.GetEmail();

                foreach (var invitation in allInvitations)
                {
                    if (userId == invitation.Reciever)
                    {
                        myInvitations.Add(invitation);
                    }
                }
            }
            return myInvitations;
        }

    }
}
