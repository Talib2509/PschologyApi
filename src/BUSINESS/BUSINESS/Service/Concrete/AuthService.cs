using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PsychologyApi.Business.DTOs;
using PsychologyApi.Business.DTOs.AuthDTO;
using PsychologyApi.Business.Service.Abstract;
using PsychologyApi.Business.Services.Abstract;
using PsychologyApi.Core.Entities.Identity;
using PsychologyApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyApi.Business.Service.Concrete
{
    public class AuthService(UserManager<AppUser> _userManager, IMapper _mapper, IJwtService _jwtService) : IAuthService
    {
        public async Task<AuthResponseDto> LoginAsync(LoginDTO dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user is null)
            {
                throw new Exception("Istifadeci tapilmadi");
            }
            var isTruePassword = await _userManager.CheckPasswordAsync(user, dto.Password);

            if (!isTruePassword)
            {
                throw new Exception("Email ve ya password duzgun deyil");
            }


            var authResponse = await _jwtService.GenerateTokensAsync(user, "");

            return authResponse;

        }

        public async Task<AuthResponseDto> RegisterAsync(RegisterDTO dto)
        {
            var isExistEmail = await _userManager.Users.AnyAsync(x => x.Email.ToLower() == dto.Email.ToLower());
            if (isExistEmail)
            {
                throw new Exception("Bu Email artiq movcuddur");
            }



            var appUser = _mapper.Map<AppUser>(dto);
            appUser.UserName = dto.Email;



            var result = await _userManager.CreateAsync(appUser, dto.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception(errors);
            }
            var user = await _userManager.FindByEmailAsync(dto.Email);

            await _userManager.AddToRoleAsync(user, Roles.User.ToString());


            //await _userManager.AddToRoleAsync(appUser, IdentityRoles.Member.ToString());
            return new();
        }
    }
}