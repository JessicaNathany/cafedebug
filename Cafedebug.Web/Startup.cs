using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cafedebug.Data;
using Cafedebug.Data.Context;
<<<<<<< HEAD
=======
using System.Globalization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Localization;
using Cafedebug.Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Cafedebug.Web.Configurations;
>>>>>>> 2df6f05dbded26c7c444d6acc0d6e3ceb23109bc

namespace Cafedebug.Web
{
    public class Startup
    {
       // recebe a injeção da classe configuration
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

            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(Microsoft.AspNetCore.Identity.UI.UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<CafedebugIdentityContext>();

            services.ResolveDependencies();

            //configuração da classe DbContext
            services.AddDbContext<CafedebugContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CafedebugConnectionString")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
