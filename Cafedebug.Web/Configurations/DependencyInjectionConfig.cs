using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Notificacoes;
using Cafedebug.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Cafedebug.Web.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection service)
        {
            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<INotifier, Notifier>();

            return service;
        }
    }
}
