using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Onlineshop.Domain.Aggregates.UserManagement;
using OnlineShop.EFCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

#region [- EF Service Configuration -]
var connectionString = builder.Configuration.GetValue<string>("ConnectionStrings:Default");
builder.Services.AddDbContext<OnlineShopDbContext>(c => c.UseSqlServer(connectionString));
#endregion

#region [- Identity Service Configuration -]
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<OnlineShopDbContext>();
builder.Services.Configure<IdentityOptions>(c =>
{
    c.Password.RequireDigit = false;
    c.Password.RequireNonAlphanumeric = false;
    c.Password.RequiredLength = 3;
    c.Password.RequireUppercase = false;
    c.Password.RequireLowercase = false;
}
); 
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
