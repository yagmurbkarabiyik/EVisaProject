using EVisa.BI.Services.Abstract;
using EVisa.BI.Services.Concrete;
using EVisa.Core.Services;
using EVisa.Dal.Context;
using EVisa.Dal.Data.Common;
using EVisa.Dal.Data.DalRepos;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<EVisaDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<,>));


builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICountryService, CountryService>();

builder.Services.AddAutoMapper(x => { });

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
