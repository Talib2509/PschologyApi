using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;


namespace PsychologyApi.Core.Entities
{
    public class Psychologist : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Specialty { get; set; } 
        public int ExperienceYears { get; set; } 
        public string Education { get; set; } 
        public string Certificates { get; set; } 
        public string SpecializationAreas { get; set; }
        public string Bio { get; set; } 
        public string Approach { get; set; } 

        public ICollection<Appointment> Appointments { get; set; }
    }
}