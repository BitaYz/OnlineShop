using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onlineshop.Domain.Aggregates.UserManagement;
using PublicTools.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EFCore.Configurations.UserManagementConfigurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            #region [- GodAdminUser Data Entry -]
            builder.ToTable(nameof(AppUser))
                .HasData(
                new AppUser
                {
                    Id = DatabaseConstants.GodAdminUsers.KhosroshahiUserId,
                    FirstName = DatabaseConstants.GodAdminUsers.KhosroshahiFirstName,
                    LastName = DatabaseConstants.GodAdminUsers.KhosroshahiLastName,
                    UserName = DatabaseConstants.GodAdminUsers.KhosroshahiCellPhone,
                    PasswordHash = DatabaseConstants.GodAdminUsers.KhosroshahiPassword.GetHashCode().ToString(),
                    CellPhone = DatabaseConstants.GodAdminUsers.KhosroshahiCellPhone
                }
                );
            #endregion

            //builder.ToTable(table => table.HasCheckConstraint(
            //DatabaseConstants.CheckConstraints.CellphoneOnlyNumericalTitle,
            //DatabaseConstants.CheckConstraints.CellphoneOnlyNumerical));
            //builder.ToTable(table => table.HasCheckConstraint(
            //    DatabaseConstants.CheckConstraints.NationalIdOnlyNumericalTitle,
            //    DatabaseConstants.CheckConstraints.NationalIdOnlyNumerical));

            //builder.ToTable(table => table.HasCheckConstraint(
            //    DatabaseConstants.CheckConstraints.NationalIdCharacterNumberTitle,
            //    DatabaseConstants.CheckConstraints.NationalIdCharacterNumber));

            builder.Property(p => p.CellPhone).IsRequired();
            builder.HasIndex(p => p.CellPhone).IsUnique();

            builder.Property(p => p.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(p => p.DateCreatedLatin).IsRequired().HasDefaultValue(System.DateTime.Now);
            builder.Property(p => p.IsModified).HasDefaultValue(false);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);

        }
    }
}
