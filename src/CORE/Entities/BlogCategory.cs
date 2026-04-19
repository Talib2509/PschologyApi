using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;


namespace PsychologyApi.Core.Entities
{
    public class BlogCategory : BaseEntity
    {
       public string Name { get; set; }
        public string Slug { get; set; }
    }
}