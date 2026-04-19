using PsychologyApi.Business.DTOs;
using PsychologyApi.Business.DTOs.AuthDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyApi.Business.Service.Abstract;

public interface IAuthService
{
    Task<AuthResponseDto> RegisterAsync(RegisterDTO dto);
    Task<AuthResponseDto> LoginAsync(LoginDTO dto);

}
