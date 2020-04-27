using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cafedebug.Data.Context;
using Cafedebug.Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Cafedebug.Web.Configurations;
using AutoMapper;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Routing;

namespace Cafedebug.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                services.AddDbContext<CafedebugContext>(option => option.UseSqlServer(Configuration.GetConnectionString("CafedebugConnectionString")));
            });

            services.AddDbContext<CafedebugIdentityContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CafedebugConnectionString")));

            services.AddAutoMapper(typeof(Startup));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<CafedebugIdentityContext>();

            services.ResolveDependencies();

            //configuração da classe DbContext
            services.AddDbContext<CafedebugContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CafedebugConnectionString")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            //configura a autenticação do identity para funcionar na aplicação
            app.UseAuthentication();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Administrador",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
