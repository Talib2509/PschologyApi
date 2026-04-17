using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PsychologyApi.Business.DTOs;
using PsychologyApi.Business.Services.Abstract;
using PsychologyApi.Core.Entities.Identity;

namespace PsychologyApi.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]

 
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtService _jwtService;

        public AuthController(UserManager<AppUser> userManager,
                              IJwtService jwtService)
        {
            _userManager = userManager;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, dto.Password))
                return Unauthorized();

            var ip = HttpContext.Connection.RemoteIpAddress?.ToString();

            var tokens = await _jwtService.GenerateTokensAsync(user, ip);

            return Ok(tokens);
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh(RefreshTokenRequestDto dto)
        {
            var ip = HttpContext.Connection.RemoteIpAddress?.ToString();

            var result = await _jwtService.RefreshTokenAsync(dto.RefreshToken, ip);

            return Ok(result);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout(RefreshTokenRequestDto dto)
        {
            var ip = HttpContext.Connection.RemoteIpAddress?.ToString();

            await _jwtService.RevokeTokenAsync(dto.RefreshToken, ip);

            return NoContent();
        }
    }
}
