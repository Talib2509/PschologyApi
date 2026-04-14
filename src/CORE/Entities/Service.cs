using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;

namespace PsychologyApi.Core.Entities
{
    public class Service : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public string WhoIsItFor { get; set; } 
        public string WhatToExpect { get; set; } 
        public string SessionFormat { get; set; } 
        public decimal? Price { get; set; } 
    }
}