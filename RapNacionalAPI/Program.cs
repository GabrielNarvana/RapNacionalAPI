using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using RapNacionalAPI.Data.Context;
using RapNacionalAPI.Data.Repositories.Interfaces;
using RapNacionalAPI.Data.Repositories;
using RapNacionalAPI.Filters;
using RapNacionalAPI.Validations;
using RapNacionalAPI.Data.UnitOfWorks.Interfaces;
using RapNacionalAPI.Data.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(c =>
{
    c.Filters.Add<ExceptionsMiddleware>();
}).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ExemploValidation>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddSwaggerGen();

builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IMusicaRepository, MusicaRepository>();
builder.Services.AddTransient<IArtistaRepository, ArtistaRepository>();
builder.Services.AddTransient<IAlbumRepository, AlbumRepository>();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


builder.Configuration.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("secrets.json");
builder.Services.AddDbContext<MainDBContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnection")));

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
