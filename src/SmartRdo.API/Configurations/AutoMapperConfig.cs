using AutoMapper;
using SmartRdo.API.ViewModels;
using SmartRdo.Business.Models;

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
