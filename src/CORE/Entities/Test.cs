using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;


namespace PsychologyApi.Core.Entities
{
    public class Test : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Duration { get; set; } 
        public ICollection<Question> Questions { get; set; }
    }
}