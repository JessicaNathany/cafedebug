using AutoMapper;
using Cafedebug.Business.Models;
using Cafedebug.Web.Areas.Administrador.ViewModels;
using Cafedebug.Web.Areas.Site.ViewModels;

namespace Cafedebug.Web.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Episode, EpisodeViewModel>().ReverseMap();
            CreateMap<Team, TeamViewModel>().ReverseMap();
            CreateMap<Contact, ContactViewModel>().ReverseMap();
        }
    }
}
