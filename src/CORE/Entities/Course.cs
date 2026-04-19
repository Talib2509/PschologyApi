using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;
using PsychologyApi.Core.Enums;

namespace PsychologyApi.Core.Entities
{
    public class Course : BaseEntity
    {
  public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public Levels Level { get; set; }
        public int Dutrition { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}