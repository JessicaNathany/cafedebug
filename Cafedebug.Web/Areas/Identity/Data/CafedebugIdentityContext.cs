using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cafedebug.Web.Areas.Identity.Data
{
    public class CafedebugIdentityContext : IdentityDbContext<IdentityUser>
    {
        public CafedebugIdentityContext(DbContextOptions<CafedebugIdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable("User");
            });

            builder.Entity<IdentityRole>(entity => {
                entity.ToTable("Role");
            });

            builder.Entity<IdentityUserRole<string>>(entity => {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity => {
                entity.ToTable("UserClaim");
            });

            builder.Entity<IdentityUserLogin<string>>(entity => {
                entity.ToTable("UserLogin");
            });

            builder.Entity<IdentityUserToken<string>>(entity => {
                entity.ToTable("UserTokens");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity => {
                entity.ToTable("RoleClaims");
            });
        }
    }
}
