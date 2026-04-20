using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PsychologyApi.Business.DTOs;
using PsychologyApi.Business.DTOs.AuthDTO;
using PsychologyApi.Business.Extensions;
using PsychologyApi.Business.Service.Abstract;
using PsychologyApi.Core.Entities.Identity;
using PsychologyApi.Core.Enums;
namespace PsychologyApi.Business.Service.Concrete
{
    public class AuthService(UserManager<AppUser> _userManager, IMapper _mapper, IJwtService _jwtService) : IAuthService
    {
        public async Task<AuthResponseDto> LoginAsync(LoginDTO dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user is null)
            {
                throw new System.Exception("Istifadeci tapilmadi");
            }
            var isTruePassword = await _userManager.CheckPasswordAsync(user, dto.Password);

            if (!isTruePassword)
            {
                throw new System.Exception("Email ve ya password duzgun deyil");// Istifadeci tapilmadi ve ya password duzgun deyil mesajini vermek daha guvenlidir, cunku bu sekilde hakerler hangi bilginin yanlis oldugunu bilemezler.
            }

            var roles = await _userManager.GetRolesAsync(user);

            var authResponse = await _jwtService.GenerateTokensAsync(user, roles.FirstOrDefault());

            return authResponse;

        }

        public async Task<AuthResponseDto> RegisterAsync(RegisterDTO dto)
        {
            var isExistEmail = await _userManager.Users.AnyAsync(x => x.Email.ToLower() == dto.Email.ToLower());
            if (isExistEmail)
            {
                throw new System.Exception("Bu Email artiq movcuddur");
            }



            var appUser = _mapper.Map<AppUser>(dto);
            appUser.UserName = dto.Email;



            var result = await _userManager.CreateAsync(appUser, dto.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new System.Exception(errors);
            }
            var user = await _userManager.FindByEmailAsync(dto.Email);

            // Role validation (təhlükəsizlik üçün)
            if (dto.Role != Roles.Teacher && dto.Role != Roles.Student)
            {
                throw new System.Exception("Yalniz Teacher ve ya Student secile biler");
            }

            // Role əlavə et
            await _userManager.AddToRoleAsync(user, dto.Role.GetRole());


            
            return new();
        }
    }
}