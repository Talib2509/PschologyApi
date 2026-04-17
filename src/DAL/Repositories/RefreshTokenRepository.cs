using Microsoft.EntityFrameworkCore;
using PsychologyApi.Core.Entities.Identity;
using PsychologyApi.Core.Repositories;
using PsychologyApi.DAL.Context;

namespace PsychologyApi.DAL.Repositories
{
    public class RefreshTokenRepository
        : GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        private readonly AppDbContext _context;

        public RefreshTokenRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<RefreshToken?> GetByTokenAsync(string token)
        {
            return await _context.RefreshTokens
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Token == token);
        }

       
    }
}