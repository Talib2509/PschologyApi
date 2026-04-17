using PsychologyApi.Business.DTOs;
using PsychologyApi.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyApi.Business.Services.Abstract
{
    public interface IJwtService
    {
        Task<AuthResponseDto> GenerateTokensAsync(AppUser user, string ipAddress);
        Task<AuthResponseDto> RefreshTokenAsync(string refreshToken, string ipAddress);
        Task RevokeTokenAsync(string refreshToken, string ipAddress);
    }
}
