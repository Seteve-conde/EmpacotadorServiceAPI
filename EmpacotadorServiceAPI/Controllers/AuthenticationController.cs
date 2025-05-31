using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmpacotadorServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authService;

        public AuthenticationController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestDTO request)
        {
            if (_authService.ValidateUser(request.Username, request.Password))
            {
                var token = _authService.GenerateJwtToken(request.Username);
                return Ok(new { token });
            }
            return Unauthorized("Usuário ou senha inválidos");
        }
    }

}
