using Microsoft.AspNetCore.Identity;
using DomainLayer.Models;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interface
{
    public interface ISignUpRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel user);
    }
}