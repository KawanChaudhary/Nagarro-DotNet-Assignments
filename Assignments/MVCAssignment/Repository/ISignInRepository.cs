using Microsoft.AspNetCore.Identity;
using MVCAssignment.Models;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
{
    public interface ISignInRepository
    {
        Task<SignInResult> PasswordSignInAsync(SignInUserModel userModel);
        Task SignOutAsync();
    }
}