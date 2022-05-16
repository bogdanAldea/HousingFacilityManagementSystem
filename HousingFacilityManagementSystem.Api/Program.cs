using HousingFacilityManagementSystem.Application.Buildings.Commands;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;
using HousingFacilityManagementSystem.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Infrastructure.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add MediatR
builder.Services.AddMediatR(typeof(CreateBuildingCommand));

// Add AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// Scoped repositories
builder.Services.AddScoped<IIdentityRepository<AdministratorProfile>, AdminIdentityRepository>();
builder.Services.AddScoped<IRepository<Building>, BuildingRepository>();
builder.Services.AddScoped<IRepository<Apartment>, ApartmentRepository>();
builder.Services.AddScoped<IRepository<BranchedConsumableUtility>, BranchedUtilityRepository>();
builder.Services.AddScoped<IRepository<Invoice>, InvoiceRepository>();
builder.Services.AddScoped<IRepository<MasterConsumableUtility>, MasterUtilityRepository>();

// Add DbContext
builder.Services.AddDbContext<HousingFacilityContext>
(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Demo"))
);

// Add Indentity Core
builder.Services.AddIdentityCore<IdentityUser>()
    .AddEntityFrameworkStores<HousingFacilityContext>();

//// JwtBearer Configurations
//var jwtSettings = new JwtSettings();
//builder.Configuration.Bind(nameof(JwtSettings), jwtSettings);

//var jwtSection = builder.Configuration.GetSection(nameof(JwtSettings));
//builder.Services.Configure<JwtSettings>(jwtSection);

builder.Services
    .AddAuthentication(auth => { 
        auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(jwt =>
    {
        jwt.SaveToken = true;
        jwt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("jfr2txodg2ccc91o45nbwl9bwau8m2mv")),
            
            ValidateIssuer = false,

            ValidateAudience = false,

        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
