using Microsoft.AspNetCore.Identity;

namespace DomainLayer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsAdmin { get; set; }

        public string CheckPassword { get; set; }
    }
}
