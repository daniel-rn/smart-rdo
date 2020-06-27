using AutoMapper;
using SmartRdo.API.ViewModels;
using SmartRdo.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRdo.API.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Atividade, AtividadeViewModel>().ReverseMap();
        }
    }
}
