using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Projeto.SeuDoutor.Domain.Entities;
using Projeto.SeuDoutor.Web.ViewModels;

namespace Projeto.SeuDoutor.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {            
            Mapper.CreateMap<PerfilMedicoViewModel, PerfilMedico>();
        }
    }
}