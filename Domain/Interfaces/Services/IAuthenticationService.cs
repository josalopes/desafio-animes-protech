using Domain.Dto;
using Microsoft.AspNetCore.Identity;

namespace Domain.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto);
    }
}
