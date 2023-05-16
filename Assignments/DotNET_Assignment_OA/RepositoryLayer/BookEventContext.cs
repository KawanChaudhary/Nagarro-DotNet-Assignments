using DomainLayer.Data;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer
{
    public class BookEventContext: IdentityDbContext<ApplicationUser>
    {
        public BookEventContext(DbContextOptions<BookEventContext> options) 
            : base(options)
        {
            
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var myInterceptor = new MyCommandInterceptor();

            IEnumerable<IInterceptor> interceptors = (IEnumerable<IInterceptor>)Enumerable.Repeat(myInterceptor, 1);

            optionsBuilder.AddInterceptors(interceptors);
        }*/
        public virtual DbSet<BookEventEntity> BookEventEntities { get; set; }

        public virtual DbSet<CommentEntity> Comments { get; set; }

        public virtual DbSet<InvitationEntity> Invitations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedUsers(builder);
        }

        private void SeedUsers(ModelBuilder builder)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Id = "1",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                IsAdmin = true,
            };

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            passwordHasher.HashPassword(user, "admin123");

            builder.Entity<ApplicationUser>().HasData(user);
        }
    }
}
