using Microsoft.EntityFrameworkCore;
using MVCAssignment.Data;
using MVCAssignment.Models;
using MVCAssignment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
{
    public class InvitationRepository : IInvitationRepository
    {
        private readonly IUserService _userService;
        private readonly BookEventContext _context;

        public InvitationRepository(IUserService userService, BookEventContext context)
        {
            _userService = userService;
            _context = context;
        }

        public async Task AddInvitation(EventViewModel bookEvent, string userId)
        {
            string invitationString = bookEvent.EventDetails.InviteByEmail;

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
                await _context.Invitations.AddAsync(newInvitation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<InvitationEntity>> GetMyInvitations()
        {
            var myInvitations = new List<InvitationEntity>();
            var allInvitations = await _context.Invitations.ToListAsync();

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
