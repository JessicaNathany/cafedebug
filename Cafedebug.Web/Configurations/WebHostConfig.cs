using Cafedebug.Data.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cafedebug.Web.Configurations
{
    public static class WebHostConfig
    {
        public static IWebHost RunMigrations(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetService<CafedebugContext>();

                context.Database.Migrate();
            }

            return host;
        }
    }
}