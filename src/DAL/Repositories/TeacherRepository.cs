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
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext _context) : base(_context)
        {

        }
    }
    
}
