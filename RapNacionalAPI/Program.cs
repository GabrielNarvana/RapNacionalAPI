using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using RapNacionalAPI.Data.Context;
using RapNacionalAPI.Filters;
using RapNacionalAPI.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(c =>
{
    c.Filters.Add<ExceptionsMiddleware>();
}).AddFluentValidation(fv=> fv.RegisterValidatorsFromAssemblyContaining<ExemploValidation>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddSwaggerGen();

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
