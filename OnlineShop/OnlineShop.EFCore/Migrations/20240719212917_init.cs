﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "UserManagement");

            migrationBuilder.EnsureSchema(
                name: "Sale");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "UserManagement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateSoftDeletedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSoftDeletedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    DateModifiedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModifiedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreatedLatin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreatedPersian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "UserManagement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DateCreatedLatin = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 20, 0, 59, 15, 256, DateTimeKind.Local).AddTicks(1991)),
                    DateCreatedPersian = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "1403/4/30"),
                    IsModified = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DateModifiedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModifiedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DateSoftDeletedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSoftDeletedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlackListToken",
                schema: "UserManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackListToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileEntityBase",
                schema: "UserManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateSoftDeletedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSoftDeletedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileEntityBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeader",
                schema: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreatedLatin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreatedPersian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    DateModifiedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModifiedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateSoftDeletedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSoftDeletedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                schema: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "UserManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "UserManagement",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "UserManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "UserManagement",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "UserManagement",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "UserManagement",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "UserManagement",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "UserManagement",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "UserManagement",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "UserManagement",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "UserManagement",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreatedLatin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreatedPersian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    DateModifiedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModifiedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateSoftDeletedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSoftDeletedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalSchema: "Sale",
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OTP",
                schema: "UserManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserRoleUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppUserRoleRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetCellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    ExpirationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ISUsed = table.Column<bool>(type: "bit", nullable: false),
                    UsedTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    UsedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    HashedExtraData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreatedLatin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreatedPersian = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OTP_AspNetUserRoles_AppUserRoleUserId_AppUserRoleRoleId",
                        columns: x => new { x.AppUserRoleUserId, x.AppUserRoleRoleId },
                        principalSchema: "UserManagement",
                        principalTable: "AspNetUserRoles",
                        principalColumns: new[] { "UserId", "RoleId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                schema: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreatedLatin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreatedPersian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    DateModifiedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModifiedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateSoftDeletedLatin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSoftDeletedPersian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_OrderHeader_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalSchema: "Sale",
                        principalTable: "OrderHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Sale",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "UserManagement",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreatedLatin", "DateCreatedPersian", "DateModifiedLatin", "DateModifiedPersian", "DateSoftDeletedLatin", "DateSoftDeletedPersian", "EntityDescription", "IsActive", "IsDeleted", "IsModified", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbbl", null, new DateTime(2024, 7, 20, 0, 59, 15, 255, DateTimeKind.Local).AddTicks(6864), "1403/4/30", null, null, null, null, null, true, false, false, "Admin", "ADMIN" },
                    { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbbo", null, new DateTime(2024, 7, 20, 0, 59, 15, 255, DateTimeKind.Local).AddTicks(6448), "1403/4/30", null, null, null, null, null, true, false, false, "GodAdmin", "GODADMIN" },
                    { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbbp", null, new DateTime(2024, 7, 20, 0, 59, 15, 255, DateTimeKind.Local).AddTicks(7131), "1403/4/30", null, null, null, null, null, true, false, false, "Support", "SUPPORT" },
                    { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbmk", null, new DateTime(2024, 7, 20, 0, 59, 15, 255, DateTimeKind.Local).AddTicks(7931), "1403/4/30", null, null, null, null, null, true, false, false, "Buyer", "BUYER" },
                    { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbml", null, new DateTime(2024, 7, 20, 0, 59, 15, 255, DateTimeKind.Local).AddTicks(7665), "1403/4/30", null, null, null, null, null, true, false, false, "Seller", "SELLER" },
                    { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbmm", null, new DateTime(2024, 7, 20, 0, 59, 15, 255, DateTimeKind.Local).AddTicks(7398), "1403/4/30", null, null, null, null, null, true, false, false, "Normal", "NORMAL" }
                });

            migrationBuilder.InsertData(
                schema: "UserManagement",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "DateCreatedLatin", "DateCreatedPersian", "DateModifiedLatin", "DateModifiedPersian", "DateSoftDeletedLatin", "DateSoftDeletedPersian", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbbn", 0, "09921808441", "2d1350f1-16ef-4a86-a95a-394981da6411", new DateTime(2024, 7, 20, 0, 59, 15, 256, DateTimeKind.Local).AddTicks(297), "1403/4/30", null, null, null, null, null, false, "Ameneh", true, "YazdiKhosroshahi", null, true, null, null, "09921808441", "AQAAAAIAAYagAAAAEGJxfAp5wNu7svO2lp1YHxP0mVcKBcTV2JEyGHW8O7K4np5up+gloG7WPbGepqAL1A==", null, false, null, "6380bb05-656b-4c76-bf75-0dbba3e7f978", false, "09921808441" });

            migrationBuilder.InsertData(
                schema: "UserManagement",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbbo", "7b43aed3-cbdc-4fa2-9516-9e99d3e5dbbn" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "UserManagement",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "UserManagement",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "UserManagement",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "UserManagement",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "UserManagement",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "UserManagement",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "UserManagement",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderHeaderId",
                schema: "Sale",
                table: "OrderDetail",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                schema: "Sale",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OTP_AppUserRoleUserId_AppUserRoleRoleId",
                schema: "UserManagement",
                table: "OTP",
                columns: new[] { "AppUserRoleUserId", "AppUserRoleRoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                schema: "Sale",
                table: "Product",
                column: "ProductCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "BlackListToken",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "FileEntityBase",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "OrderDetail",
                schema: "Sale");

            migrationBuilder.DropTable(
                name: "OTP",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "OrderHeader",
                schema: "Sale");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Sale");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "ProductCategory",
                schema: "Sale");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "UserManagement");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "UserManagement");
        }
    }
}
