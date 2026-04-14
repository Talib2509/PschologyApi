using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;

namespace PsychologyApi.Core.Entities
{
    public class BlogPost : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string CoverImageUrl { get; set; }
        public string Author { get; set; }
        public int ReadingTimeInMinutes { get; set; } 
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}