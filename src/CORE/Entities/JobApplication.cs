using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;

namespace PsychologyApi.Core.Entities
{
    public class JobApplication : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CvUrl { get; set; } 
        public string? CoverLetter { get; set; } 
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }
    }
}