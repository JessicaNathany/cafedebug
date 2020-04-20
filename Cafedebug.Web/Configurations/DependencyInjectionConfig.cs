using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Notificacoes;
using Cafedebug.Business.Services;
using Cafedebug.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Cafedebug.Web.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection service)
        {
            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<INotifier, Notifier>();

            service.AddScoped<IEpisodeRepository, EpisodioRepository>();
            service.AddScoped<IEpisodeService, EpisodeService>();

            service.AddScoped<ITeamRepository, TeamRepository>();
            service.AddScoped<ITeamService, TeamService>();

            service.AddScoped<IContactRepository, ContactRepository>();
            service.AddScoped<IContactService, ContactService>();




            return service;
        }
    }
}
