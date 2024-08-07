﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopDomain.Aggregates.UserManagement;
using PublicTools.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EFCore.Configurations.IdentityConfiguration
{
    public class OnlineShopUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.ToTable(nameof(AppUserRole)).HasData(
        new AppUserRole
        {
            UserId = DatabaseConstants.GodAdminUsers.YazdiUserId,
            RoleId = DatabaseConstants.DefaultRoles.GodAadminId
        });

            builder.HasKey(p=>  new{ p.UserId , p.RoleId});
        }
    }
}
