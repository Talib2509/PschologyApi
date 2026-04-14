using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;


namespace PsychologyApi.Core.Entities
{
    public class Vacancy : BaseEntity
    {
        public string PositionTitle { get; set; } 
        public string Location { get; set; }
        public string JobType { get; set; } 
        public string Description { get; set; } 
        public string Requirements { get; set; } 
        public string Responsibilities { get; set; } 
        public string WeOffer { get; set; } 

        
        public ICollection<JobApplication> JobApplications { get; set; }
    }
}