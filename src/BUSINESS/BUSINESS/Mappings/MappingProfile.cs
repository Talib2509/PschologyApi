using AutoMapper;
using PsychologyApi.Business.DTOs.AuthDTO;
using PsychologyApi.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyApi.Business.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterDTO, AppUser>();
        }
    }
}

