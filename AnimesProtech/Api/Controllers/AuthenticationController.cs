using Microsoft.AspNetCore.Mvc;

using Domain.Dto;
using Domain.Interfaces.Services;

namespace Api.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AuthenticationController(IServiceManager service)
        {
            _service = service;
        }

        /// <summary>
        /// Cria um novo usuário
        /// </summary>
        /// <remarks>
        ///     POST api/authentication
        ///         {
        ///             "firstname": "",
        ///             "lastname": "",
        ///             "username": "jose",
        ///             "password": "1234567890",
        ///             "email": "jose@exemplo.com",
        ///             "phonenumber": "123456789",
        ///             "Roles": ["Administrator", "Manager"]
        ///         }
        /// </remarks>
        /// <param name="userForRegistration"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistration);
           
            if (!result.Succeeded) 
            {
                foreach (var error in result.Errors) 
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        /// <summary>
        /// Efetua login de usuário e retorna seu token de autenticação
        /// </summary>
        /// <remarks>
        /// POST api/authentication/login
        ///     {
        ///         "username": "jose",
        ///         "password": "1234567890"
        ///     }
        /// </remarks>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _service.AuthenticationService.ValidateUser(user))
            {
                return Unauthorized();
            }

            return Ok(new { Token = await _service.AuthenticationService.CreateToken() });
        }
    }
}
