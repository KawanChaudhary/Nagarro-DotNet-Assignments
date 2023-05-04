using Microsoft.AspNetCore.Identity;
using MVCAssignment.Models;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
{
    public interface ISignUpRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel user);
    }
}