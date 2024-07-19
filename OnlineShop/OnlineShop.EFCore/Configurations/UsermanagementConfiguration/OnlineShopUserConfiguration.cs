using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopDomain.Aggregates.UserManagement;
using PublicTools.Constants;
using PublicTools.Tools;


namespace OnlineShop.EFCore.Configurations.IdentityConfiguration
{
    public class OnlineShopUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        ///*************************************    Questionnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
        #region [-Configuration-]
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable(nameof(AppUser)).HasData(
                        new AppUser
                        {
                            Id = DatabaseConstants.GodAdminUsers.YazdiUserId,
                            FirstName = DatabaseConstants.GodAdminUsers.YazdiFirstName,
                            LastName = DatabaseConstants.GodAdminUsers.YazdiLastName,
                            Cellphone = DatabaseConstants.GodAdminUsers.YazdiCellPhone,
                            UserName = DatabaseConstants.GodAdminUsers.YazdiCellPhone,
                            PasswordHash = "AQAAAAIAAYagAAAAEGJxfAp5wNu7svO2lp1YHxP0mVcKBcTV2JEyGHW8O7K4np5up+gloG7WPbGepqAL1A==",
                            //Password :!QAZ1qaz
                            //DatabaseConstants.GodAdminUsers.YazdiPassword.GetHashCode().ToString(),
                            IsActive = true,
                            DateCreatedLatin = DateTime.Now,
                            DateCreatedPersian = Helpers.ConvertToPersianDate(DateTime.Now),
                            IsDeleted = false,
                            IsModified = false,
                            NormalizedUserName = DatabaseConstants.GodAdminUsers.YazdiCellPhone.ToString(),
                            LockoutEnabled = true
                        });

            //    builder.ToTable(table => table.HasCheckConstraint(
            //DatabaseConstants.CheckConstraints.CellphoneOnlyNumericalTitle,
            //DatabaseConstants.CheckConstraints.CellphoneOnlyNumerical));
            //    builder.ToTable(table => table.HasCheckConstraint(
            //        DatabaseConstants.CheckConstraints.NationalIdOnlyNumericalTitle,
            //        DatabaseConstants.CheckConstraints.NationalIdOnlyNumerical));
            //    builder.ToTable(table => table.HasCheckConstraint(
            //        DatabaseConstants.CheckConstraints.CellphoneOnlyNumericalTitle,
            //        DatabaseConstants.CheckConstraints.CellphoneOnlyNumerical));

            //    builder.ToTable(table => table.HasCheckConstraint(
            //        DatabaseConstants.CheckConstraints.NationalIdCharacterNumberTitle,
            //        DatabaseConstants.CheckConstraints.NationalIdCharacterNumber));

            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();

            builder.Property(p => p.Cellphone).IsRequired();
            builder.Property(p => p.Cellphone).IsUnicode();

            builder.Property(p => p.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(p => p.IsModified).HasDefaultValue(false);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);

            builder.Property(p => p.DateCreatedLatin).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(p => p.DateCreatedPersian).IsRequired().HasDefaultValue(Helpers.ConvertToPersianDate(DateTime.Now));
        } 
        #endregion

    }
}
