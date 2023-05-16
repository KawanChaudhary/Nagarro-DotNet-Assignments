using Microsoft.AspNetCore.Identity;
using DomainLayer.Models;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interface
{
    public interface ISignInRepository
    {
        Task<SignInResult> PasswordSignInAsync(SignInUserModel userModel);
        Task SignOutAsync();
    }
}