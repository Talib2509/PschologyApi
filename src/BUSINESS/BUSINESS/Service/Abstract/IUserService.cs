using Microsoft.AspNetCore.Http;
using PsychologyApi.Business.DTOs;
using System.Threading.Tasks;

namespace PsychologyApi.Business.Services.Abstract
{

    public interface IUserService
    {
        Task<UserDto> GetUserByIdAsync(int id);
        Task<string> UploadProfileImageAsync(int id, IFormFile file);
    }
}