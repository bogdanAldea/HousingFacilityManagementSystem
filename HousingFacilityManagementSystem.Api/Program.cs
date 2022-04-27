using HousingFacilityManagementSystem.Application.Buildings.Commands;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;
using HousingFacilityManagementSystem.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
builder.Services.AddScoped<IRepository<Building>, BuildingRepository>();
builder.Services.AddScoped<IRepository<Apartment>, ApartmentRepository>();
builder.Services.AddScoped<IRepository<BranchedConsumableUtility>, BranchedUtilityRepository>();
builder.Services.AddScoped<IRepository<Invoice>, InvoiceRepository>();
builder.Services.AddScoped<IRepository<MasterConsumableUtility>, MasterUtilityRepository>();

// Add DbContext
builder.Services.AddDbContext<HousingFacilityContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Demo"))
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
