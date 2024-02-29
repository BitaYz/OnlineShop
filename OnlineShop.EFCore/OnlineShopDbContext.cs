using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Onlineshop.Domain.Aggregates.UserManagement;
using Onlineshop.Domain.Frameworks.Absracts;
using OnlineShop.EFCore.Frameworks;
using PublicTools.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EFCore
{
    public class OnlineShopDbContext : IdentityDbContext<AppUser , AppRole, string ,
        IdentityUserClaim<string> , AppUserRole , IdentityUserLogin<string> ,
        IdentityRoleClaim<string> , IdentityUserToken<string>>
    {
        public OnlineShopDbContext(DbContextOptions options) : base(options) 
        {
        }

        #region [- ConfigureConventions(ModelConfigurationBuilder configurationBuilder) -]
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }
        #endregion

        #region [- OnModelCreating(ModelBuilder modelBuilder) -]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DatabaseConstants.Schemas.UserManagement);

            #region [- ApplyConfigurationsFromAssembly() -]
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion

            #region [- RegisterAllEntities() -]
            modelBuilder.RegisterAllEntities<IDbSetEntity>(typeof(IDbSetEntity).Assembly);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        #endregion

    }
}
