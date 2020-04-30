using AutoMapper;
using Cafedebug.Business.Models;
using Cafedebug.Web.Areas.Administrador.ViewModels;
using Cafedebug.Web.ViewModels;

namespace Cafedebug.Web.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Episode, EpisodeViewModel>().ReverseMap();
            CreateMap<Team, Areas.Administrador.ViewModels.TeamViewModel>().ForMember(dest => dest.ImagemUpload, act => act.Ignore()).ReverseMap();
            CreateMap<Team, ViewModels.TeamViewModel>().ReverseMap();
            CreateMap<Contact, ContactViewModel>().ReverseMap();
        }
    }
}
