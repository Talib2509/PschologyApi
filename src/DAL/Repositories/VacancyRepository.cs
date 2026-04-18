using PsychologyApi.Core.Entities;
using PsychologyApi.Core.Repositories;
using PsychologyApi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyApi.DAL.Repositories
{
    public class VacancyRepository : GenericRepository<Vacancy>, IVacancyRepository
    {
        public VacancyRepository(AppDbContext _context) : base(_context)
        {

        }
    }
    
}
