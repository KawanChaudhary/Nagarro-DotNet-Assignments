using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCAssignment.Models;

namespace MVCAssignment.Data
{
    public class BookEventContext: IdentityDbContext<ApplicationUser>
    {
        public BookEventContext(DbContextOptions<BookEventContext> options) 
            : base(options)
        {
            
        }
        public DbSet<BookEventEntity> BookEventEntities { get; set; }

        public DbSet<CommentEntity> Comments { get; set; }

        public DbSet<InvitationEntity> Invitations { get; set; }
    }
}
