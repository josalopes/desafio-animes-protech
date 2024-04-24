using Microsoft.AspNetCore.Identity;

using Domain.Dto;

namespace Domain.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
