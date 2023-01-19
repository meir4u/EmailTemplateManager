using AutoMapper;
using EmailTemplateManager.Application.DTOs.EmailTemplate;
using EmailTemplateManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailTemplateManager.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmailTemplateModel, EmailTemplateDto>().ReverseMap();
        }
    }
}
